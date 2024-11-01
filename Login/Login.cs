using SistemaLogin;
using System.Data;

namespace SistemaLogin
{
    public partial class Login : Form
    {
        public static Cadastro cadastro = new Cadastro();
        public static EsqueceuSenha esqueceuSenha = new EsqueceuSenha();

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = usuarioText.Text;
            string senha = senhaText.Text;

            ValidaCampos valida = new ValidaCampos();
            bool flag = valida.ValidaLogin(user, senha);

            if (flag)
            {
                string comandoSQL = $"SELECT * FROM usuarios WHERE user=\"{user}\"";
                var resultado = ConectaDB.ConectarDB(comandoSQL);

                SenhaHash senhaobj = new SenhaHash();
                string senhaHash = senhaobj.GeraHash(senha);

                LoginValido valido = new LoginValido();

                if (valido.Valido(resultado,user,senha))
                {
                    successText("*logado com sucesso");
                }

                else if (!valido.Valido(resultado, user, senha))
                {
                    errorText("*usuário ou senha incorreto");
                }
            }
        }

        public void successText(string msg)
        {
            responseLabel.Visible = true;
            responseLabel.ForeColor = Color.Green;
            responseLabel.Text = msg;
        }

        public void errorText(string msg)
        {
            responseLabel.Visible = true;
            responseLabel.ForeColor = Color.Red;
            responseLabel.Text = msg;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            esqueceuSenha.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
