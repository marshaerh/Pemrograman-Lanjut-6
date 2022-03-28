using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "Marsharh" && textBox2.Text == "Marsharh1")
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Maaf username/password salah!");
                textBox1.Text = "Username";
                textBox2.Text = "Password";
                textBox1.Focus();

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
