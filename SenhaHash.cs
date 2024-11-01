using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal class SenhaHash
    {
        public string GeraHash(string senha)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(senha);
            string senhaHash = Convert.ToBase64String(byteArray);
            return senhaHash;
        }
    }
}
