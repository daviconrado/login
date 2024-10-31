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
            bool eFlag = false;
            errorText1.Text = "";

            bool userSymbol = user.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));

            if (senha1 != senha2)
            {
                eFlag = true;
                errorText1.Text += "\r\n*as senhas devem ser iguais";
            }
            if (senha1 == "" || senha2 == "" || user == "") {
                eFlag = true;
                errorText1.Text += "\r\n*todos os campos devem ser preenchidos";
            }
            if (userSymbol)
            {
                eFlag = true;
                errorText1.Text += "\r\n*o campo usuário não deve conter símbolos";
            }
            if (!email.Contains("@")||email.EndsWith("@"))
            {
                eFlag = true;
                errorText1.Text += "\r\n*insira um email válido";
            }


            if (!eFlag) {
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(senha1);
                string senhaHash = Convert.ToBase64String(byteArray);

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
                        errorText1.Text += "\r\n erro no cadastro";
                    }

                }
            }
        }
    }
}
