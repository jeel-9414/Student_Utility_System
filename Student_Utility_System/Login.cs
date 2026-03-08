using Oracle.ManagedDataAccess.Client;

namespace Student_Utility_System
{
    public partial class Login : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521";
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
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



                string query1 = $@"select USER_ID,username,password from user1 where username='{utxt.Text}' and password='{ptxt.Text}'";
                OracleCommand cmd2 = new OracleCommand(query1, con);
                OracleDataReader reader = cmd2.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Username Doesn't Exist!");
                    con.Close();
                    return;
                }

                if (reader.Read())
                {
                    Program.loggedInUserID = Convert.ToInt32(reader["User_ID"]);
                    MessageBox.Show("Login Successfully!");
                    con.Close();

                    Menustrip menu = new Menustrip();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registraion registraion = new Registraion();
            registraion.Show();
            this.Hide();
        }
    }
}
