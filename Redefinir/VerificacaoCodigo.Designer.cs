namespace SistemaLogin
{
    partial class VerificacaoCodigo
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            emailLabel = new Label();
            codigoText = new TextBox();
            validarButton = new Button();
            label2 = new Label();
            reenviarCodigoLabel = new LinkLabel();
            label3 = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(413, 50);
            label1.TabIndex = 0;
            label1.Text = "Insira o código de 6 dígitos que foi enviado para o seu email\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(12, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(413, 23);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "email";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // codigoText
            // 
            codigoText.BorderStyle = BorderStyle.FixedSingle;
            codigoText.Location = new Point(12, 137);
            codigoText.MaxLength = 6;
            codigoText.Name = "codigoText";
            codigoText.Size = new Size(413, 23);
            codigoText.TabIndex = 2;
            codigoText.TextAlign = HorizontalAlignment.Center;
            // 
            // validarButton
            // 
            validarButton.BackColor = Color.RoyalBlue;
            validarButton.FlatStyle = FlatStyle.Flat;
            validarButton.Location = new Point(12, 199);
            validarButton.Name = "validarButton";
            validarButton.Size = new Size(413, 32);
            validarButton.TabIndex = 3;
            validarButton.Text = "Validar";
            validarButton.UseVisualStyleBackColor = false;
            validarButton.Click += validarButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 4;
            label2.Text = "Código";
            // 
            // reenviarCodigoLabel
            // 
            reenviarCodigoLabel.DisabledLinkColor = Color.Lime;
            reenviarCodigoLabel.Location = new Point(12, 288);
            reenviarCodigoLabel.Name = "reenviarCodigoLabel";
            reenviarCodigoLabel.Size = new Size(413, 20);
            reenviarCodigoLabel.TabIndex = 5;
            reenviarCodigoLabel.TabStop = true;
            reenviarCodigoLabel.Text = "Reenviar código";
            reenviarCodigoLabel.TextAlign = ContentAlignment.MiddleCenter;
            reenviarCodigoLabel.VisitedLinkColor = Color.Lime;
            reenviarCodigoLabel.LinkClicked += reenviarCodigoLabel_LinkClicked;
            // 
            // label3
            // 
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(413, 16);
            label3.TabIndex = 6;
            label3.Text = "Não recebeu nenhum código?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(15, 172);
            errorLabel.Margin = new Padding(0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(413, 15);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "error";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // VerificacaoCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(437, 331);
            Controls.Add(errorLabel);
            Controls.Add(label3);
            Controls.Add(reenviarCodigoLabel);
            Controls.Add(label2);
            Controls.Add(validarButton);
            Controls.Add(codigoText);
            Controls.Add(emailLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "VerificacaoCodigo";
            Text = "Sistema de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label emailLabel;
        private TextBox codigoText;
        private Button validarButton;
        private Label label2;
        private LinkLabel reenviarCodigoLabel;
        private Label label3;
        private Label errorLabel;
    }
}