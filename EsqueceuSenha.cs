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
    public partial class EsqueceuSenha : Form
    {
        public static VerificacaoCodigo verificacaoCodigo = new VerificacaoCodigo();
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = userText.Text;
            bool eFlag = false;

            if (usuario == "")
            {
                eFlag = true;
                errorLabel.Text += "*insira um usuário válido";
                errorLabel.Visible = true;
            }

            if (!eFlag)
            {
                var retorno = ConectaDB.ConectarDB($"SELECT email FROM usuarios WHERE user=\"{usuario}\"");
                if(retorno.Rows.Count == 1)
                {
                    DataRow dataRow = retorno.Rows[0];
                    string email = dataRow.Field<string>("email");
                    verificacaoCodigo.mostraEmail(email);
                    Login.esqueceuSenha.Close();
                    verificacaoCodigo.ShowDialog();
                }
                else
                {
                    errorLabel.Text = "*esse usuário não foi cadastrado";
                    errorLabel.Visible = true;
                }
            }
        }
    }
}
