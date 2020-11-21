using BluewayWinForms.UI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PassPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string User { get; private set; }

        // TODO:MongoDB First ile yapılacak.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2.User = txtLoginUser.Text;
            string EvUser = txtLoginUser.Text;
            string EvPassword = txtLoginPassword.Text;
            MongoCRUD db = new MongoCRUD("URL");
            List<UserCC> liste = db.LoadRecords<UserCC>("Users");

            foreach (UserCC v in liste)
            {
                
                if (v.Name==EvUser)
                {
                    if (v.Password == EvPassword) 
                    {
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı");
                    }
                }
            }
            

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}