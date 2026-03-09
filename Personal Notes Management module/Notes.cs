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

namespace Personal_Notes_Management_module
{
    public partial class Notes : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        bool isEdit = false;
        int notes_id = 0;
        public Notes()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            titletxt.Clear();
            contenttxt.Clear();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            if (isEdit)
            {
                con.Open();
                string query = $@"Update Notes set Title='{titletxt.Text}',content='{contenttxt.Text}' where Notes_ID={notes_id}";
                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                Clear();
                loadData();
                MessageBox.Show("Data Updated Sucessfully!");
                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                    string query = $@"Insert into notes (Notes_ID,User_ID,Title,Content) values (Notes_ID.NEXTVAL,{Program.LoggedInUserID},'{titletxt.Text}','{contenttxt.Text}')";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Sucessfully");
                    Clear();
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

        public void loadData()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select * from Notes";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

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

                dataGridView1.Columns["Notes_ID"].Visible = false;
                dataGridView1.Columns["User_ID"].Visible = false;
                Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editbtn")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                notes_id = Convert.ToInt32(row.Cells["Notes_ID"].Value);
                titletxt.Text = row.Cells["Title"].Value.ToString();
                contenttxt.Text = row.Cells["Content"].Value.ToString();
                isEdit = true;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Deletebtn")
            {
                OracleConnection con = new OracleConnection(connect);
                if (MessageBox.Show("Are You Sure You Want To Delete Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        notes_id = Convert.ToInt32(row.Cells["Notes_ID"].Value);
                        string query = $@"Delete from Notes where Notes_ID={notes_id}";

                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();

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

        private void Notes_Load(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;
        }
    }
}
