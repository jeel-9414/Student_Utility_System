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
    public partial class Login : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            if (utxt.Text == "" || ptxt.Text == "")
            {
                MessageBox.Show("Please Enter All Fields!");
                return;
            }
            try
            {
                con.Open();
                string query = $@"Select user_id,username,password from user2 where username='{utxt.Text}' and password='{ptxt.Text}'";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();

                //if (!reader.Read())
                //{
                //    MessageBox.Show("User Dosen't Exist!");
                //    con.Close();
                //    return;
                //}

                if (reader.Read())
                {
                    Program.LoggedInUserID = Convert.ToInt32(reader["User_ID"]);
                    MessageBox.Show("Login Sucessfully!");
                    con.Close();

                    MenuStrip menuStrip = new MenuStrip();
                    menuStrip.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password or User Dosen't Exist!");
                    con.Close();
                    return;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
