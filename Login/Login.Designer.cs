namespace SistemaLogin
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usuarioText = new TextBox();
            senhaText = new TextBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            responseLabel = new Label();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-1, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 43);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 89);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 153);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // usuarioText
            // 
            usuarioText.Location = new Point(441, 117);
            usuarioText.Name = "usuarioText";
            usuarioText.PlaceholderText = "usuário";
            usuarioText.Size = new Size(207, 23);
            usuarioText.TabIndex = 4;
            // 
            // senhaText
            // 
            senhaText.Location = new Point(441, 184);
            senhaText.Name = "senhaText";
            senhaText.PlaceholderText = "senha";
            senhaText.Size = new Size(207, 23);
            senhaText.TabIndex = 5;
            senhaText.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(441, 251);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 6;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 286);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 7;
            label4.Text = "Não tem uma conta?\r\n";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(565, 286);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Inscrever-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // responseLabel
            // 
            responseLabel.AutoSize = true;
            responseLabel.ForeColor = Color.Green;
            responseLabel.Location = new Point(441, 219);
            responseLabel.Name = "responseLabel";
            responseLabel.Size = new Size(178, 15);
            responseLabel.TabIndex = 9;
            responseLabel.Text = "*cadastro efetuado com sucesso";
            responseLabel.Visible = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(441, 314);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Esqueceu sua senha?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(713, 394);
            Controls.Add(linkLabel2);
            Controls.Add(responseLabel);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(senhaText);
            Controls.Add(usuarioText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Login";
            Text = "Sistema de Login";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usuarioText;
        private TextBox senhaText;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label responseLabel;
        private LinkLabel linkLabel2;
    }
}
