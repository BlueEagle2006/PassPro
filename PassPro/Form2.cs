using BluewayWinForms.UI.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string EvUser = txtLoginUser.Text;
            string EvPassword = txtLoginPassword.Text;
            MongoCRUD db = new MongoCRUD("URL");
            List<UserCC> liste = db.LoadRecords<UserCC>("Users");
            int i = 0;
            foreach (UserCC v in liste)
            {
                if (liste[i].Name==EvUser)
                {
                    if (liste[i].Password == EvPassword)
                    {
                    }
                }

                i += 1;
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }
    }
}