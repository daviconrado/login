using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class VerificacaoCodigo : Form
    {
        public static RedefinirSenha redefinirSenha = new RedefinirSenha();
        private int codigo { get; set; }
        public string Email { get; set; }
        public VerificacaoCodigo()
        {
            InitializeComponent();
        }
        public void mostraEmail(string emailR)
        {
            Email = emailR;
            string emailMask = MascaraEmail.MaskEmail(Email);
            emailLabel.Text = emailMask;
            GeraCodigo geraCodigo = new GeraCodigo();
            codigo = geraCodigo.GeradorCodigo();
            EnviaEmail.SendEmail(Email, codigo);
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            if (codigoText.Text == codigo.ToString())
            {
                redefinirSenha.ShowDialog();
                EsqueceuSenha.verificacaoCodigo.Close();
            }
            else
            {
                errorLabel.Text = "*o código inserido está incorreto";
                errorLabel.Visible = true;
            }
        }

        private void reenviarCodigoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnviaEmail.SendEmail(Email, codigo);
            reenviarCodigoLabel.Enabled = false;
            reenviarCodigoLabel.Text = "O email foi reenviado com sucesso";
        }
    }
}
