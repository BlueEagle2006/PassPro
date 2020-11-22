using System;
using System.Windows.Forms;
using System.Collections.Generic;
// team
using PassPro1;
using PassPro.Database;

namespace PassPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string YeniSifre(int length = 8)
        {
            Random rand = new Random();
            string alf = "abcdefghiklmnopqrstuvwxyz.,*-1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ:;?_!'^+%&/()=j@\\|#${[]} ";
            string result = "";
            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(alf.Length);
                char karakter = alf[index];
                result = result + karakter;
            }
            return result;
        }

        public void addDetailsToList()
        {
            try
            {
                // load details from database
                List<Detail> details = DetailRepository.Service.LoadDetails();

                // clear list
                listResult.Text = "";

                // TODO: burada ne yapiyor?
                string user = Form2.User;

                // add to list
                foreach (Detail v in details)
                {
                    if (v.User == user)
                    {
                        listResult.Text += $"{v.Web}/{v.Name}..................................{v.Content}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddURL_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = YeniSifre();
            }

            Detail detail = new Detail();
            detail.User = Form2.User;
            detail.Web = textAddWeb.Text;
            detail.Name = txtAddURL.Text;
            detail.Content = txtPassword.Text;

            // insert to database
            DetailRepository.Service.InsertDetail(detail);

            MessageBox.Show("Password Saved");

            txtPassword.Text = "";
            txtAddURL.Text = "";
            textAddWeb.Text = "";

            addDetailsToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addDetailsToList();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            List<Detail> liste = DetailRepository.Service.LoadDetails();

            listResult.Text = "";

            string a = txtSearchURL.Text;
            string user = Form2.User;

            foreach (Detail v in liste)
            {
                for (int j = 0; j <= v.Name.Length - a.Length; j++)
                {
                    if (a == v.Name.Substring(j, a.Length) && v.User == user)
                    {
                        listResult.Text += $"{v.Web}--{v.Name}.................................{v.Content}\n";
                        break;
                    }
                }
            }
        }
    }
}