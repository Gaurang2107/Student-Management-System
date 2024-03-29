using assignment_2_C_;

namespace assignment_3_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StudentDB.ReadStudentsFromFile();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidUser(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Invalid user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Home home = new Home();
                home.ShowDialog();
            }
        }

        private bool IsValidUser(string Username, string Password)
        {
            try
            {
                string[] userCredentials = File.ReadAllLines("C:\\Users\\gdham\\source\\repos\\assignment_3_c#\\user.txt");
                if (userCredentials.Length == 1)
                {
                    string[] split = userCredentials[0].Split(',');
                    if (split.Length == 2)
                    {
                        string storedUsername = split[0];
                        string storedPassword = split[1];
                        return Username == storedUsername && Password == storedPassword;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading user credentials: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}