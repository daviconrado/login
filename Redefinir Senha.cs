using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha1 = senhaText1.Text;
            string senha2 = senhaText2.Text;

            bool eFlag = false;

            if (senha1 != senha2)
            {
                eFlag = true;
                errorText.Text = "*as senhas devem ser iguais";
                errorText.Visible = true;
            }
            if (senha1 == "" || senha2 == "")
            {
                eFlag = true;
                errorText.Text = "*todos os campos devem ser preenchidos";
                errorText.Visible = true;
            }

            if (!eFlag)
            {
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(senha1);
                string senhaHash = Convert.ToBase64String(byteArray);
                UpdateSenha(senhaHash);
            }
        }

        private void UpdateSenha(string senha1)
        {
            string email = EsqueceuSenha.verificacaoCodigo.Email;
            ConectaDB.ConectarDB($"UPDATE usuarios SET password=\"{senha1}\" WHERE email=\"{email}\"");
            Program.login.successText("*senha alterada com sucesso");
            VerificacaoCodigo.redefinirSenha.Close();
        }
    }
}
