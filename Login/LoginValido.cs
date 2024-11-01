using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.AccessControl;

namespace SistemaLogin
{
    internal class LoginValido
    {
        public bool Valido(DataTable resultado,string user,string senha)
        {
            bool valido = false;

            SenhaHash a = new SenhaHash();
            string senhaHash = a.GeraHash(senha);

            if (resultado.Rows.Count == 0)
            {
                valido = false;
                return false;
            }

            DataRow dataRow = resultado.Rows[0];

            if (dataRow.Field<string>("user") != user || dataRow.Field<string>("password") != senhaHash)
            {
                valido = false;
            }

            else if (dataRow.Field<string>("user") == user && dataRow.Field<string>("password") == senhaHash)
            {
                valido = true;
            }

            return valido;
        }
    }
}
