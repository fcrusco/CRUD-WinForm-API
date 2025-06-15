namespace CRUD
{
    public partial class Form1 : Form
    {

        private UsuarioRepository repo = new UsuarioRepository();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var sobrenome = txtSobreNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Nome e Sobrenome são obrigatórios.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuarioId.Text)) // INSERT
            {
                int novoId = repo.Inserir(nome, sobrenome);
                AtualizarGrid();
                MessageBox.Show("Inserido com sucesso! ID: " + novoId);
            }
            else // UPDATE
            {
                int id = int.Parse(txtUsuarioId.Text);
                repo.Atualizar(id, nome, sobrenome);
                AtualizarGrid();
                MessageBox.Show("Atualizado com sucesso.");
            }

            LimparCampos();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                txtUsuarioId.Text = dgvUsuarios.CurrentRow.Cells["UsuarioId"].Value.ToString();
                txtNome.Text = dgvUsuarios.CurrentRow.Cells["Nome"].Value.ToString();
                txtSobreNome.Text = dgvUsuarios.CurrentRow.Cells["SobreNome"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            txtUsuarioId.Text = "";
            txtNome.Text = "";
            txtSobreNome.Text = "";
        }

        private void AtualizarGrid()
        {
            dgvUsuarios.DataSource = repo.ListarTodos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para apagar.");
                return;
            }

            string nome = dgvUsuarios.CurrentRow.Cells["Nome"].Value.ToString();
            string sobrenome = dgvUsuarios.CurrentRow.Cells["SobreNome"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja apagar o usuário:\n\n{nome} {sobrenome}?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UsuarioId"].Value);
                repo.Deletar(id);
                btnListar.PerformClick();
                MessageBox.Show("Deletado com sucesso.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = repo.ListarTodos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = repo.ListarTodos();
        }
    }
}
