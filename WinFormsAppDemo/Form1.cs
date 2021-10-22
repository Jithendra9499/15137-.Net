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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtpwd.Text == "123")
            {
                lblMsg.Text = "valid User";

            }
            else
            {
                lblMsg.Text = "Invalid UserName or Password";
            }



        }
    }
}
