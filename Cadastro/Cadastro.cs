using Mysqlx.Crud;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = usuarioText.Text;
            string senha1 = senhaText.Text;
            string senha2 = repSenhaText.Text;
            string email = emailText.Text;
            errorText1.Text = "";

            ValidaCampos valida = new ValidaCampos();
            bool valido = valida.ValidaCadastro(user, senha1, senha2, email);

            if (valido) {
                SenhaHash geraHash = new SenhaHash();
                string senhaHash = geraHash.GeraHash(senha1);


                var retorno = ConectaDB.ConectarDB($"insert into usuarios(user, password, email) values(\"{user}\", \"{senhaHash}\",\"{email}\")");
                if(retorno.Columns.Count == 0)
                {
                    Login.cadastro.Close();
                    Program.login.successText("*o cadastro foi concluido com sucesso");
                }
                else
                {
                    DataRow row = retorno.Rows[0];
                    string error = row.Field<string>("error");

                    if(error.Contains("Duplicate") == true)
                    {
                        errorText("*erro no cadastro");
                    }

                }
            }
        }

        public void errorText(string msg)
        {
            errorText1.Visible = true;
            errorText1.ForeColor = Color.Red;
            errorText1.Text = msg;
        }
    }
}
