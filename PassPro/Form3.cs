using System;
using System.Windows.Forms;
// team
using PassPro.Database;

namespace PassPro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                User user = new User();
                user.Name = txtUsername.Text;
                user.Password = txtPassword.Text;

                // insert user to database
                UserRepository.Service.InsertUser(user);

                MessageBox.Show("User Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("You Can't Let Username or Password Blank");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
