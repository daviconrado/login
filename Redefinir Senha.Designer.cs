namespace SistemaLogin
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            senhaText1 = new TextBox();
            button1 = new Button();
            errorText = new Label();
            label4 = new Label();
            senhaText2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
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
            pictureBox1.Location = new Point(0, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 43);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "REDEFINIR SENHA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(375, 94);
            label2.Name = "label2";
            label2.Size = new Size(339, 41);
            label2.TabIndex = 2;
            label2.Text = "Redefina sua senha\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 135);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha\r\n";
            // 
            // senhaText1
            // 
            senhaText1.Location = new Point(441, 153);
            senhaText1.Name = "senhaText1";
            senhaText1.PlaceholderText = "senha";
            senhaText1.Size = new Size(207, 23);
            senhaText1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(441, 286);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 6;
            button1.Text = "Redefinir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.ForeColor = Color.Red;
            errorText.Location = new Point(441, 245);
            errorText.Name = "errorText";
            errorText.Size = new Size(32, 15);
            errorText.TabIndex = 7;
            errorText.Text = "error";
            errorText.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 179);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 8;
            label4.Text = "Repita a senha";
            // 
            // senhaText2
            // 
            senhaText2.Location = new Point(441, 200);
            senhaText2.Name = "senhaText2";
            senhaText2.PlaceholderText = "senha";
            senhaText2.Size = new Size(207, 23);
            senhaText2.TabIndex = 9;
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(713, 394);
            Controls.Add(senhaText2);
            Controls.Add(label4);
            Controls.Add(errorText);
            Controls.Add(button1);
            Controls.Add(senhaText1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "RedefinirSenha";
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
        private TextBox senhaText1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label errorText;
        private Label label4;
        private TextBox senhaText2;
    }
}
