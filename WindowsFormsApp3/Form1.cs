using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (txtname.Text == "")

                btnsayhello.Enabled = false;

            else

                btnsayhello.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblenteryourname_MouseLeave(object sender, EventArgs e)
        {
            lblenteryourname.Text = "enter your name:";
            lblenteryourname.ForeColor = Color.Black;
        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {
            string s;

            s =  " hello " + txtname.Text;

            lblreasult.Text =  s;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            lblreasult.Text = "";

            txtname.Focus();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text == "")

                btnsayhello.Enabled = false;

            else

                btnsayhello.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("خدافظ");
          
                Application.Exit();

            
        }
    }
}
