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

namespace Student_Utility_System
{
    public partial class Student : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        string photopath = "";
        int student_id = 0;
        bool isEdit = false;
        public Student()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            nametxt.Clear();
            emailtxt.Clear();
            malerb.Checked = false;
            femalerb.Checked = false;
            dob.Value = DateTime.Now;
            city.Text = "";
            phonenotxt.Text = "";
            profpic.Image = null;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            int age = DateTime.Now.Year - dob.Value.Year;
            string gender = "";

            if (malerb.Checked)
            {
                gender = malerb.Text;
            }
            else
            {
                gender = femalerb.Text;
            }

            if (nametxt.Text == "" || emailtxt.Text == "" || gender == "" || dob.Text == "" || city.Text == "" || phonenotxt.Text == "" || photopath == "")
            {
                MessageBox.Show("All Fields Are Mandatory!");
                return;
            }

            if (isEdit)
            {
                try
                {
                    con.Open();

                    string query = $@"Update Student set name='{nametxt.Text}',email='{emailtxt.Text}',gender='{gender}',dob=TO_DATE('{dob.Value:dd-MM-yyyy}','DD-MM-YYYY'),city='{city.Text}',phoneno='{phonenotxt.Text}',Photograph='{photopath}' where Student_ID={student_id}";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data updated Sucessfully!");
                    displayData();
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


                    string query = $@"Insert Into Student (student_id,name,email,gender,dob,city,phoneno,photograph,User_ID,age)values(Student_ID.NEXTVAL,'{nametxt.Text}','{emailtxt.Text}','{gender}','{dob.Text}','{city.Text}','{phonenotxt.Text}','{photopath}',{Program.loggedInUserID},{age})";
                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Inserted Sucessfully!");
                    clear();
                    displayData();
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }



        private void profpicbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                profpic.Image = Image.FromFile(openFileDialog1.FileName);
                photopath = openFileDialog1.FileName;
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
        }

        public void displayData()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();

                string query = "Select *  from Student";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Data found!");
                    return;
                }
                dataGridView1.DataSource = dt;


                if (!dataGridView1.Columns.Contains("ProfPic"))
                {
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    img.HeaderText = "Image";
                    img.Name = "ProfPic";
                    dataGridView1.Columns.Add(img);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string path = row.Cells["Photograph"].Value.ToString();

                    if (File.Exists(path))
                    {
                        row.Cells["ProfPic"].Value = Image.FromFile(path);
                    }
                }

                //2nd Time For Practice Purpose And Understanding Only!!

                //DataGridViewImageColumn col = new DataGridViewImageColumn();
                //col.HeaderText = "Image";
                //col.Name = "ProfPIC";
                //dataGridView1.Columns.Add(col);

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    string path = row.Cells["Photograph"].Value.ToString();

                //    if (File.Exists(path))
                //    {
                //        row.Cells["Photograph"].Value= Image.FromFile(path);
                //    }
                //}

                if (!dataGridView1.Columns.Contains("Editbtn"))
                {
                    DataGridViewButtonColumn Editbtn = new DataGridViewButtonColumn();
                    Editbtn.Name = "Editbtn";
                    Editbtn.HeaderText = "Action";
                    Editbtn.Text = "Edit";
                    Editbtn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(Editbtn);

                    DataGridViewButtonColumn Deletebtn = new DataGridViewButtonColumn();
                    Deletebtn.Name = "Deletebtn";
                    Deletebtn.HeaderText = "Action";
                    Deletebtn.Text = "Delete";
                    Deletebtn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(Deletebtn);
                }

                dataGridView1.Columns["Student_ID"].Visible = false;
                dataGridView1.Columns["User_ID"].Visible = false;
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
            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editbtn")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                student_id = Convert.ToInt32(row.Cells["Student_ID"].Value);
                nametxt.Text = row.Cells["Name"].Value.ToString();
                emailtxt.Text = row.Cells["Email"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                if (gender == "Male")
                {
                    malerb.Checked = true;
                }
                else
                {
                    femalerb.Checked = true;
                }
                dob.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                city.Text = row.Cells["City"].Value.ToString();
                phonenotxt.Text = row.Cells["PhoneNo"].Value.ToString();
                photopath = row.Cells["Photograph"].Value.ToString();
                profpic.Image = Image.FromFile(photopath);
                isEdit = true;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Deletebtn")
            {
                OracleConnection con = new OracleConnection(connect);
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        int Student_ID = Convert.ToInt32(row.Cells["Student_ID"].Value);
                        string query = $@"Delete from student where Student_Id={Student_ID}";

                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Sucessfully!");
                        dataGridView1.DataSource = null;
                        displayData();
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

        private void Student_Load_1(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;
        }
    }

}
