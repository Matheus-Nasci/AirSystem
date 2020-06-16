using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void HoraFechar_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "Digite seu usuário...")
                txtuser.Text = "";
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
                txtuser.Text = "Digite seu usuário...";
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Digite sua senha...")
                txtpass.Text = "";
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
                txtpass.Text = "Digite sua senha...";
            txtpass.UseSystemPasswordChar = true;
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }
    }
}
