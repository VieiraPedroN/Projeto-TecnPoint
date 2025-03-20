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
            btnCadastrar = new Button();
            textEmail = new TextBox();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(335, 154);
            textNome.Name = "textNome";
            textNome.Size = new Size(125, 27);
            textNome.TabIndex = 0;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(335, 245);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(125, 27);
            textSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(335, 316);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(335, 201);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textEmail);
            Controls.Add(btnCadastrar);
            Controls.Add(textSenha);
            Controls.Add(textNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textSenha;
        private Button btnCadastrar;
        private TextBox textEmail;
    }
}
