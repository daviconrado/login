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
            bool eFlag = false;

            bool userSymbol = user.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));

            if (user == "" || senha == "")
            {
                eFlag = true;
                errorText("*todos os campos devem ser preenchidos");
            }

            if (userSymbol)
            {
                eFlag = true;
                errorText("*o campo usuário não deve conter símbolos");
            }

            if (!eFlag)
            {
                string comandoSQL = $"SELECT * FROM usuarios WHERE user=\"{user}\"";
                var resultado = ConectaDB.ConectarDB(comandoSQL);

                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(senha);
                string senhaHash = Convert.ToBase64String(byteArray);

                if (resultado.Rows.Count == 0)
                {
                    errorText("*usuário ou senha incorreto");
                    return;
                }
                DataRow dataRow = resultado.Rows[0];

                if (dataRow.Field<string>("user") != user || dataRow.Field<string>("password") != senhaHash)
                {
                    errorText("*usuário ou senha incorreto");
                }

                else if (dataRow.Field<string>("user") == user && dataRow.Field<string>("password") == senhaHash)
                {
                    successText("logado com sucesso");
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
    }
}
