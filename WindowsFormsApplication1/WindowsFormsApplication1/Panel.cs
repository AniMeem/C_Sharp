using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           String username = textBox1.Text;
           String password = textBox2.Text;

           if (username == "Anika" && password == "123")
           {
               MessageBox.Show("Succcessfully Login");
           }
           else
           {
               MessageBox.Show("Invalid Username or Password");
           }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
