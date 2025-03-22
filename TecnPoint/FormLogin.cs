using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Infra;

namespace TecnPoint
{
    public partial class FormLogin : Form
    {
        public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=L@lpkbr123;Database=supt";
            using (var conectar = new NpgsqlConnection(connString))
            {
                try
                {
                    string email = textAcsEmail.Text;

                    conectar.Open();
                    string query = "SELECT * FROM usuario WHERE email = @email AND senha = @senha";
                    using (var cmd = new NpgsqlCommand(query, conectar))
                    {
                        cmd.Parameters.AddWithValue("email", textAcsEmail.Text);
                        cmd.Parameters.AddWithValue("senha", textAcsSenha.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login bem-sucedido!");
                                FormCadastroUser formPrincipal = new FormCadastroUser();

                                if (email == "admin@gmail.com")
                                {
                                    FormVwUser formVwUser = new FormVwUser();
                                    formVwUser.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    formPrincipal.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }
    }
}
