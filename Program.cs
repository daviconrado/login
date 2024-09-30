using System;
using System.Runtime.InteropServices;

namespace SistemaLogin
{
    internal static class Program
    {
        public static Login login = new Login();
        [STAThread]
        static void Main(string[] args)
        {
            login.ShowDialog();
        }
    }
}