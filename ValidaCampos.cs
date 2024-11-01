using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaLogin
{
    internal class ValidaCampos
    {

        public bool ValidaLogin(string user, string senha)
        {
            bool valido = false;
            bool userSymbol = user.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));
            if (user == "" || senha == "")
            {
                valido = true;
                Program.login.errorText("*todos os campos devem ser preenchidos");
            }

            if (userSymbol)
            {
                valido = true;
                Program.login.errorText("*todos os campos devem ser preenchidos");
            }

            return valido;
        }

        public bool ValidaCadastro(string user, string senha1, string senha2, string email)
        {
            bool valido = true;
            bool userSymbol = user.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));

            if (senha1 != senha2)
            {
                valido = false;
                Login.cadastro.errorText("*as senhas devem ser iguais");
            }
            if (senha1 == "" || senha2 == "" || user == "")
            {
                valido = false;
                Login.cadastro.errorText("*todos os campos devem ser preenchidos");
            }
            if (userSymbol)
            {
                valido = false;
                Login.cadastro.errorText("*o campo usuário não deve conter símbolos");
            }
            if (senha1.Length<5)
            {
                valido = false;
                Login.cadastro.errorText("*a senha deve conter pelo menos 5 caracteres");
            }
            if (!email.Contains("@") || email.EndsWith("@"))
            {
                valido = false;
                Login.cadastro.errorText("*insira um email válido");
            }

            return valido;
        }
    }
}
