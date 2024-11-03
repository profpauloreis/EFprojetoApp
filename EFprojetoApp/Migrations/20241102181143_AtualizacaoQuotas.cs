using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFprojetoApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoQuotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotas_Socios_SociosId",
                table: "Quotas");

            migrationBuilder.DropIndex(
                name: "IX_Quotas_SociosId",
                table: "Quotas");

            migrationBuilder.DropColumn(
                name: "SociosId",
                table: "Quotas");

            migrationBuilder.CreateIndex(
                name: "IX_Quotas_SocioId",
                table: "Quotas",
                column: "SocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotas_Socios_SocioId",
                table: "Quotas",
                column: "SocioId",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotas_Socios_SocioId",
                table: "Quotas");

            migrationBuilder.DropIndex(
                name: "IX_Quotas_SocioId",
                table: "Quotas");

            migrationBuilder.AddColumn<int>(
                name: "SociosId",
                table: "Quotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quotas_SociosId",
                table: "Quotas",
                column: "SociosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotas_Socios_SociosId",
                table: "Quotas",
                column: "SociosId",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
