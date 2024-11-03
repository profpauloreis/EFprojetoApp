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

            // Cria uma nova instância do contexto da base de dados
            // Array.Empty<string>() é usado como argumento para o método CreateDbContext
            _context = new MeuDbContextFactory().CreateDbContext(Array.Empty<string>());
        }

        // Evento que é disparado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Chama o método para carregar os dados iniciais
            CarregarDados();
        }

        // Método responsável por carregar os dados do base de dados e exibi-los no DataGridView
        private void CarregarDados()
        {
            try
            {
                // Procura todos os sócios da base de dados e converte para uma lista
                var socios = _context.Socios.ToList();

                // Define a fonte de dados do DataGridView como a lista de sócios
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

        // Método para configurar a aparência das colunas do DataGridView
        private void ConfigurarColunas()
        {
            // Define os textos dos cabeçalhos das colunas
            dataGridViewSocios.Columns["Id"].HeaderText = "ID";
            dataGridViewSocios.Columns["Nome"].HeaderText = "Nome";
            dataGridViewSocios.Columns["Email"].HeaderText = "E-mail";
            dataGridViewSocios.Columns["DataDeEntrada"].HeaderText = "Data de Entrada";

            // Se houver alguma coluna que não queiramos exibir
            if (dataGridViewSocios.Columns["Quotas"] != null)
            {
                dataGridViewSocios.Columns["Quotas"].Visible = false;
            }
        }

        // Sobrescreve o método OnFormClosing para limpar recursos quando o formulário for fechado
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Libera os recursos do contexto da base de dados
            _context.Dispose();
        }

        // Evento de clique do botão na toolbar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
