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
            int eFlag = 0;
            errorText1.Text = "";

            bool userSymbol = user.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));
            bool senhaSymbol = senha1.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));
            bool senha2Symbol = senha2.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));

            if (senha1 != senha2)
            {
                eFlag = 1;
                errorText1.Text += "\r\n*as senhas devem ser iguais";
            }
            if (senha1 == "" || senha2 == "" || user == "") {
                eFlag = 1;
                errorText1.Text += "\r\n*todos os campos devem ser preenchidos";
            }
            if (userSymbol || senhaSymbol || senha2Symbol)
            {
                eFlag = 1;
                errorText1.Text += "\r\n*os campos não devem conter símbolos";
            }


            if (eFlag == 0) {
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(senha1);
                string senhaHash = Convert.ToBase64String(byteArray);

                var retorno = ConectaDB.ConectarDB($"insert into usuarios(user, password) values(\"{user}\", \"{senhaHash}\")");
                if(retorno.Columns.Count != 1)
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
                        errorText1.Text += "\r\n*esse usuario já existe";
                    }

                }
            }
        }
    }
}
