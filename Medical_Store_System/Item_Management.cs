using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class Item_Management : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        bool isEdit = false;
        int item_id = 0;
        public Item_Management()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            nametxt.Clear();
            ccb.SelectedIndex = -1;
            quantity.Value = 0;
            pricetxt.Clear();
            expdate.Value = DateTime.Now;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            if (isEdit)
            {
                try
                {
                    con.Open();
                    string query = $@"Update Items set name='{nametxt.Text}',category='{ccb.Text}',quantity={quantity.Value},price={pricetxt.Text},expiry_date=TO_DATE('{expdate.Value:dd-MM-yyyy}','DD-MM-YYYY') where item_id={item_id}";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Sucessfully!");
                    loadData();
                    Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string query = $@"Insert into Items (Item_ID,User_ID,Name,Category,quantity,Price,Expiry_Date) values (Item_id.NEXTVAL,{Program.LoggedInUserID},'{nametxt.Text}','{ccb.Text}',{quantity.Value},{pricetxt.Text},TO_DATE('{expdate.Text:dd-MM-yyyy}','DD-MM-YYYY'))";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Sucessfully!");
                    loadData();
                    Clear();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        public void loadData()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select * from items";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


                dataGridView1.Columns["Item_ID"].Visible = false;
                dataGridView1.Columns["User_ID"].Visible = false;
                if (!dataGridView1.Columns.Contains("Editbtn"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Name = "Editbtn";
                    btn.Text = "Edit";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn);

                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    btn1.HeaderText = "Action";
                    btn1.Name = "Deletebtn";
                    btn1.Text = "Delete";
                    btn1.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn1);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dispbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select * from items where category='{ccb.Text}'";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Data Does Not Found!");
                    con.Close();
                    return;
                }

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Item_ID"].Visible = false;
                dataGridView1.Columns["User_ID"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editbtn")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                item_id = Convert.ToInt32(row.Cells["Item_id"].Value);
                nametxt.Text = row.Cells["Name"].Value.ToString();
                ccb.Text = row.Cells["Category"].Value.ToString();
                quantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
                pricetxt.Text = row.Cells["Price"].Value.ToString();
                expdate.Value = Convert.ToDateTime(row.Cells["Expiry_date"].Value);
                isEdit = true;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Deletebtn")
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OracleConnection con = new OracleConnection(connect);

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    item_id = Convert.ToInt32(row.Cells["Item_id"].Value);
                    try
                    {
                        con.Open();
                        string query = $@"Delete from Items where item_id={item_id}";

                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Deleted Sucessfully!");
                        loadData();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void Item_Management_Load(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;
        }
    }
}
