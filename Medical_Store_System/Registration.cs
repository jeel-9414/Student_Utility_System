using Oracle.ManagedDataAccess.Client;

namespace Medical_Store_System
{
    public partial class Registration : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            if (utxt.Text == "" || ptxt.Text == "" || cptxt.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory!");
                return;
            }

            if (ptxt.Text != cptxt.Text)
            {
                MessageBox.Show("Password is Not Matching!");
                con.Close();
                return;
            }

            try
            {
                con.Open();
                string query1 = $@"Select user_id,username,password from  user2 where username='{utxt.Text}' and password='{ptxt.Text}'";

                OracleCommand cmd1 = new OracleCommand(query1, con);
                OracleDataReader reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Username Already Exist!");
                    con.Close();
                    return;
                }

                string query = $@"Insert into user2 values (user2_id.NEXTVAL,'{utxt.Text}','{ptxt.Text}')";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Sucessfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
