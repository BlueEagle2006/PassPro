using System;
using System.Windows.Forms;
// team
using PassPro.Database;

namespace PassPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string User { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2.User = txtLoginUser.Text;
            string evUser = txtLoginUser.Text;
            string evPassword = txtLoginPassword.Text;

            var user = UserRepository.Service.Login(evUser, evPassword);

            // kullanıcı bulunamazsa user null gelir
            if (user == null)
            {
                MessageBox.Show("Username or Password is wrong!");
            }
            else
            {
                this.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}