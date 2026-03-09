using Oracle.ManagedDataAccess.Client;

namespace Personal_Notes_Management_module
{
    public partial class Registration : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";

        public Registration()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            if (utxt.Text == "" || ptxt.Text == "")
            {
                MessageBox.Show("All Fileds Are Mandatory!");
                return;
            }

            try
            {
                con.Open();
                string query = $@"Select * from user3 where username='{utxt.Text}'";
                OracleCommand cmd1 = new OracleCommand(query, con);
                OracleDataReader reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Use Already Exist!");
                    con.Close();
                    return;
                }


                string query1 = $@"Insert Into User3 (User_ID,Username,Password) values (User3_ID.NEXTVAL,'{utxt.Text}','{ptxt.Text}')";

                if (ptxt.Text != cptxt.Text)
                {
                    MessageBox.Show("Password is not Matching!");
                    con.Close();
                    return;
                }

                OracleCommand cmd = new OracleCommand(query1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Sucessfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void utxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
