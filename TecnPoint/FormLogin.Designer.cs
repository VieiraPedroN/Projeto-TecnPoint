namespace TecnPoint
{
    partial class FormLogin
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
            textAcsEmail = new TextBox();
            textAcsSenha = new TextBox();
            BtnAcessar = new Button();
            SuspendLayout();
            // 
            // textAcsEmail
            // 
            textAcsEmail.Cursor = Cursors.IBeam;
            textAcsEmail.Location = new Point(324, 165);
            textAcsEmail.Name = "textAcsEmail";
            textAcsEmail.Size = new Size(125, 27);
            textAcsEmail.TabIndex = 0;
            // 
            // textAcsSenha
            // 
            textAcsSenha.Cursor = Cursors.IBeam;
            textAcsSenha.Location = new Point(324, 218);
            textAcsSenha.Name = "textAcsSenha";
            textAcsSenha.PasswordChar = '*';
            textAcsSenha.Size = new Size(125, 27);
            textAcsSenha.TabIndex = 1;
            // 
            // BtnAcessar
            // 
            BtnAcessar.Cursor = Cursors.Hand;
            BtnAcessar.Location = new Point(324, 284);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(94, 29);
            BtnAcessar.TabIndex = 2;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            BtnAcessar.Click += BtnAcessar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAcessar);
            Controls.Add(textAcsSenha);
            Controls.Add(textAcsEmail);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAcsEmail;
        private TextBox textAcsSenha;
        private Button BtnAcessar;
    }
}