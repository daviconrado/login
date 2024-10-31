using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal class GeraCodigo
    {
        public int GeradorCodigo()
        {
            Random random = new Random();
            int codigo = random.Next(100000, 1000000);
            return codigo;
        }
    }
}
