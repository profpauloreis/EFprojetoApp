using EFprojetoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFprojetoApp
{
    public partial class Form1 : Form
    {
        // Contexto da base de dados como campo privado somente para leitura
        private readonly MeuDbContext _context;

        public Form1()
        {

            InitializeComponent();

            // Cria uma nova inst�ncia do contexto da base de dados
            // Array.Empty<string>() � usado como argumento para o m�todo CreateDbContext
            _context = new MeuDbContextFactory().CreateDbContext(Array.Empty<string>());
        }

        // Evento que � disparado quando o formul�rio � carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Chama o m�todo para carregar os dados iniciais
            CarregarDados();
        }

        // M�todo respons�vel por carregar os dados do base de dados e exibi-los no DataGridView
        private void CarregarDados()
        {
            try
            {
                // Procura todos os s�cios da base de dados e converte para uma lista
                var socios = _context.Socios.ToList();

                // Define a fonte de dados do DataGridView como a lista de s�cios
                dataGridViewSocios.DataSource = socios;

                // Opcional: Configurar as colunas do DataGridView
                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe uma mensagem para o utilizador
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para configurar a apar�ncia das colunas do DataGridView
        private void ConfigurarColunas()
        {

            // Configura��es b�sicas
            dataGridViewSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSocios.MultiSelect = false;
            dataGridViewSocios.RowHeadersVisible = false;

            // Estilo
            dataGridViewSocios.BackgroundColor = Color.LightGray;
            dataGridViewSocios.DefaultCellStyle.BackColor = Color.White;
            dataGridViewSocios.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewSocios.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewSocios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Cabe�alho
            dataGridViewSocios.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewSocios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewSocios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);


            // Define os textos dos cabe�alhos das colunas
            dataGridViewSocios.Columns["Id"].HeaderText = "ID";
            dataGridViewSocios.Columns["Nome"].HeaderText = "Nome";
            dataGridViewSocios.Columns["Email"].HeaderText = "E-mail";
            dataGridViewSocios.Columns["DataDeEntrada"].HeaderText = "Data de Entrada";

            // Se houver alguma coluna que n�o queiramos exibir
            if (dataGridViewSocios.Columns["Quotas"] != null)
            {
                dataGridViewSocios.Columns["Quotas"].Visible = false;
            }
        }

        // Sobrescreve o m�todo OnFormClosing para limpar recursos quando o formul�rio for fechado
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Libera os recursos do contexto da base de dados
            _context.Dispose();
        }

        // Evento de clique do bot�o na toolbar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridViewSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSocios.SelectedRows.Count == 0) return;

            var row = dataGridViewSocios.SelectedRows[0];
            txtNumero.Text = row.Cells["Id"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            dtpDataDeEntrada.Value = Convert.ToDateTime(row.Cells["DataDeEntrada"].Value);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoSocio = new Socios
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    DataDeEntrada = dtpDataDeEntrada.Value
                };

                _context.Socios.Add(novoSocio);
                _context.SaveChanges();
                CarregarDados();
                LimparCampos();
                MessageBox.Show("S�cio adicionado com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar s�cio: {ex.Message}", "Erro");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSocios.SelectedRows.Count == 0) return;

                var id = (int)dataGridViewSocios.SelectedRows[0].Cells["Id"].Value;
                var socio = _context.Socios.Find(id);

                if (socio != null)
                {          
                    socio.Nome = txtNome.Text;
                    socio.Email = txtEmail.Text;
                    socio.DataDeEntrada = dtpDataDeEntrada.Value;

                    _context.SaveChanges();
                    CarregarDados();
                    LimparCampos();
                    MessageBox.Show("S�cio atualizado com sucesso!", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar s�cio: {ex.Message}", "Erro");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSocios.SelectedRows.Count == 0) return;

                var id = (int)dataGridViewSocios.SelectedRows[0].Cells["Id"].Value;
                var socio = _context.Socios.Find(id);

                if (socio != null)
                {
                    _context.Socios.Remove(socio);
                    _context.SaveChanges();
                    CarregarDados();
                    MessageBox.Show("S�cio removido com sucesso!", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover s�cio: {ex.Message}", "Erro");
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            dtpDataDeEntrada.Value = DateTime.Now;
        }

    }

}




