using System;
using System.Windows.Forms;

namespace PassPro
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            Form1 form1 = new Form1();
            form1.ShowDialog();
            
            this.Close();
        }
    }
}