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

            try
            {
                con.Open();
                string query = $@"Insert into user1 (user_id, username, password) values(user_ID.NEXTVAL,'{utxt.Text}','{ptxt.Text}')";
                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login Successfully!");
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
