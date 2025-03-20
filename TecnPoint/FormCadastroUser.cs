using TecnPoint.Infra;

namespace TecnPoint
{
    public partial class FormCadastroUser : Form
    {
        public List<Usuario> Usuarios {  get; private set; } = new List<Usuario>();
        public FormCadastroUser()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try 
            { 
                var nome = textNome.Text;
                var email = textEmail.Text;
                var senha = textSenha.Text;

                foreach (var item in Usuarios)
                {
                    if (item.Email == email)
                    {
                        MessageBox.Show(email + " já cadastrado no sistema");
                        return;
                    } 
                }

                var usuario = new Usuario(nome, email, senha);
                Usuarios.Add(usuario);

                var repository = new UsuariosAdd();
                repository.Add(usuario);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
