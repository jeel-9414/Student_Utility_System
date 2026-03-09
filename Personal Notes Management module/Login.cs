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
    public partial class Login : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";

        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
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
                string query1 = $@"Select username from user3 where username='{utxt.Text}'";
                OracleCommand cmd1 = new OracleCommand(query1, con);
                OracleDataReader reader1 = cmd1.ExecuteReader();

                if (!reader1.Read())
                {
                    MessageBox.Show("User Doesn't Exist");
                    con.Close();
                    return;
                }
                string query = $@"Select user_id,username,password from user3 where username='{utxt.Text}' and password='{ptxt.Text}'";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader = cmd.ExecuteReader();
                

                if (reader.Read())
                {
                    Program.LoggedInUserID = Convert.ToInt32(reader["User_ID"]);
                    MessageBox.Show("Login Sucessfully!");
                    con.Close();

                    MenuStrip note=new MenuStrip();
                    note.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                    con.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
