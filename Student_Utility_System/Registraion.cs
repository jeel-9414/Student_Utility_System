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
    public partial class Registraion : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";

        public Registraion()
        {
            InitializeComponent();
        }

        private void Registraion_Load(object sender, EventArgs e)
        {

        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            if (utxt.Text == "" || ptxt.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password!");
                return;
            }
            try
            {
                con.Open();
                string query = $@"Insert into user1 (user_id,username,password) values (User_ID.NEXTVAL,'{utxt.Text}','{ptxt.Text}')";
                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();

                if (ptxt.Text != cptxt.Text)
                {
                    MessageBox.Show("Password  is not matching!");
                    return;
                }

                MessageBox.Show("Registartion Sucessfully!");
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
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
