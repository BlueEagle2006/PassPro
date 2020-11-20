using BluewayWinForms.UI.Database;
using PassPro1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public void listResult1()
        {
            MongoCRUD db = new MongoCRUD("URL");
            try { 
            List<Class> liste = db.LoadRecords<Class>("All");
            int i = 0;
            listResult.Text = "";
            foreach (Class v in liste) 
            {
                listResult.Text += $"{liste[i].Web}/{liste[i].Name}..................................{liste[i].Content}\n";
                i += 1;
            }
            }
            catch
            {
                return;
            }
        }
        private void btnAddURL_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = YeniSifre();
            };
            Class class1 = new Class();
            class1.Web= textAddWeb.Text;
            class1.Name = txtAddURL.Text;
            class1.Content = txtPassword.Text;
            MongoCRUD db = new MongoCRUD("URL");
            db.InsertRecord("All", class1);
            MessageBox.Show("Password Saved");
            txtPassword.Text = "";
            txtAddURL.Text = "";
            textAddWeb.Text = "";
            listResult1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listResult1();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("URL");
            List<Class> liste = db.LoadRecords<Class>("All");
            int i = 0;
            listResult.Text = "";
            string a = txtSearchURL.Text;
            foreach (Class v in liste)
            {
                for(int j = 0 ; j <= liste[i].Name.Length-a.Length ; j++)
                {

                    if (a==liste[i].Name.Substring(j,a.Length))
                    {
                        listResult.Text += $"{liste[i].Web}/{liste[i].Name}..................................{liste[i].Content}\n";
                        break;
                    }
                }
                    
                i += 1;
            }
        }
    }
}