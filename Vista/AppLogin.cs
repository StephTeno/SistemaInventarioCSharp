using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.HOME;

namespace Vista
{
    public partial class frmAppLogin : Form
    {
        public frmAppLogin()
        {
            InitializeComponent();
            txtUser.BorderFocusColor = Color.LightSkyBlue;
        }
        public void VaciarTextbox()
        {
            foreach (var c in this.Controls)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Texts = "";
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Texts != "a" || txtPassword.Texts != "a")
            {
                txtUser.BorderColor = Color.Red; txtPassword.BorderColor = Color.Red;
                lblErrorLogin.Visible = true;
            }
            else
            {
                frmHome home = new frmHome();
                VaciarTextbox();
                home.Show();
                this.Hide();
                home.FormClosing += Frm_Closing;
            }
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
            txtPassword.BorderColor = Color.White;
        }

        private void txtUser__TextChanged(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
            txtUser.BorderColor = Color.White;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnLogin_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseEnter(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseLeave(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.MidnightBlue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.MidnightBlue;
        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
