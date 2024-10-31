namespace SistemaLogin
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usuarioText = new TextBox();
            senhaText = new TextBox();
            button1 = new Button();
            repSenhaText = new TextBox();
            errorText1 = new Label();
            label4 = new Label();
            emailText = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkViolet;
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
            pictureBox1.Location = new Point(60, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            label1.Text = "CADASTRO";
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
            label3.Location = new Point(441, 177);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // usuarioText
            // 
            usuarioText.Location = new Point(441, 107);
            usuarioText.Name = "usuarioText";
            usuarioText.PlaceholderText = "usuário";
            usuarioText.Size = new Size(207, 23);
            usuarioText.TabIndex = 4;
            // 
            // senhaText
            // 
            senhaText.Location = new Point(441, 195);
            senhaText.Name = "senhaText";
            senhaText.PlaceholderText = "senha";
            senhaText.Size = new Size(207, 23);
            senhaText.TabIndex = 5;
            senhaText.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(440, 295);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // repSenhaText
            // 
            repSenhaText.Location = new Point(440, 224);
            repSenhaText.Name = "repSenhaText";
            repSenhaText.PlaceholderText = "repetir senha";
            repSenhaText.Size = new Size(207, 23);
            repSenhaText.TabIndex = 7;
            repSenhaText.UseSystemPasswordChar = true;
            // 
            // errorText1
            // 
            errorText1.AutoSize = true;
            errorText1.ForeColor = Color.Red;
            errorText1.Location = new Point(441, 250);
            errorText1.Name = "errorText1";
            errorText1.Size = new Size(0, 15);
            errorText1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 133);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // emailText
            // 
            emailText.Location = new Point(441, 151);
            emailText.Name = "emailText";
            emailText.PlaceholderText = "email@email.com";
            emailText.Size = new Size(206, 23);
            emailText.TabIndex = 10;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(713, 394);
            Controls.Add(emailText);
            Controls.Add(label4);
            Controls.Add(errorText1);
            Controls.Add(repSenhaText);
            Controls.Add(button1);
            Controls.Add(senhaText);
            Controls.Add(usuarioText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Cadastro";
            Text = "Sistema de Login";
            Load += Cadastro_Load;
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
        private PictureBox pictureBox1;
        private TextBox repSenhaText;
        private Label errorText1;
        private Label label4;
        private TextBox emailText;
    }
}
