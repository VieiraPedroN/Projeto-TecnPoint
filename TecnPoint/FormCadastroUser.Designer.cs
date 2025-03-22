namespace TecnPoint
{
    partial class FormCadastroUser
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
            textNome = new TextBox();
            textSenha = new TextBox();
            BtnCadastrar = new Button();
            textEmail = new TextBox();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Cursor = Cursors.IBeam;
            textNome.Location = new Point(335, 154);
            textNome.Name = "textNome";
            textNome.Size = new Size(125, 27);
            textNome.TabIndex = 0;
            // 
            // textSenha
            // 
            textSenha.Cursor = Cursors.IBeam;
            textSenha.Location = new Point(335, 245);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(125, 27);
            textSenha.TabIndex = 2;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Cursor = Cursors.Hand;
            BtnCadastrar.Location = new Point(335, 316);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(94, 29);
            BtnCadastrar.TabIndex = 3;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += btnCadastrar_Click;
            // 
            // textEmail
            // 
            textEmail.Cursor = Cursors.IBeam;
            textEmail.Location = new Point(335, 201);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 1;
            // 
            // FormCadastroUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textEmail);
            Controls.Add(BtnCadastrar);
            Controls.Add(textSenha);
            Controls.Add(textNome);
            Name = "FormCadastroUser";
            Text = "FormCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textEmail;
        private TextBox textSenha;
        private Button BtnCadastrar;
        
    }
}
