using ERPMega.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPMega.Forms
{
    public partial class FrmLogin : Form
    {
        private DataContext _context;
        public FrmLogin()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void Logar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Os campos Login e Senha devem ser preenchidos.", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else
            {
                var user = _context.Usuario.FirstOrDefault(c => c.Login == txtUsuario.Text.Trim() && c.Senha == txtSenha.Text.Trim().ToLower());

                if (user != null)
                {
                    if (user.Login == txtUsuario.Text.Trim() && user.Senha == txtSenha.Text.Trim().ToLower())
                    {

                        this.Hide();
                        var principal = new Principal();
                        principal.Closed += (s, args) => this.Close();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha inválido!", "Alerta", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }
    }
}
