using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFprojetoApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Inserir dados na tabela Socios
            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "Id", "Nome", "Email", "DataDeEntrada" },
                values: new object[,]
                {
            { 1, "João Silva", "joao.silva@email.com", new DateTime(2023, 1, 1) },
            { 2, "Maria Oliveira", "maria.oliveira@email.com", new DateTime(2023, 2, 15) },
            { 3, "Pedro Santos", "pedro.santos@email.com", new DateTime(2023, 3, 20) }
                });

            // Inserir dados na tabela Quotas
            migrationBuilder.InsertData(
                table: "Quotas",
                columns: new[] { "Id", "SocioId", "DataPagamento", "Valor" }, // Corrigido para SocioId
                values: new object[,]
                {
            { 1, 1, new DateTime(2023, 1, 15), 50.00m },
            { 2, 1, new DateTime(2023, 2, 15), 50.00m },
            { 3, 2, new DateTime(2023, 2, 20), 50.00m },
            { 4, 3, new DateTime(2023, 3, 25), 50.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove os dados na ordem inversa (primeiro Quotas, depois Socios)
            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4 });

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });
        }
    }
}
