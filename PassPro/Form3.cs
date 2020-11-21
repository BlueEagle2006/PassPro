using BluewayWinForms.UI.Database;
using System;
using System.Windows.Forms;

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
                UserCC user = new UserCC();
                user.Name = txtUsername.Text;
                user.Password = txtPassword.Text;
                MongoCRUD db = new MongoCRUD("URL");
                db.InsertRecord("Users", user);
                MessageBox.Show("User Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("You Can't Let Username or Password Blank");
            }
        }
    }
}
