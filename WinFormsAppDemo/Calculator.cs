using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDemo
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int result = int.Parse(txtFirst.Text) - int.Parse(txtSecond.Text);
            lblMsg.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = int.Parse(txtFirst.Text) * int.Parse(txtSecond.Text);
            lblMsg.Text = result.ToString();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = int.Parse(txtFirst.Text) + int.Parse(txtSecond.Text);
            lblMsg.Text = result.ToString();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSecond.Text) > 1)
            {
                int result = int.Parse(txtFirst.Text) / int.Parse(txtSecond.Text);
                lblMsg.Text = result.ToString();
            }
            else
            {
                lblMsg.Text = "cannot divide by 0";
            }
        }
    }
}
