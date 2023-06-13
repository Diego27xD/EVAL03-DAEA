using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemo2.Migrations
{
    public partial class v2addmodels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_People_ClientPersonID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ClientPersonID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientPersonID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Invoices",
                newName: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PersonID",
                table: "Invoices",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_People_PersonID",
                table: "Invoices",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_People_PersonID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PersonID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Invoices",
                newName: "CustomerID");

            migrationBuilder.AddColumn<int>(
                name: "ClientPersonID",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientPersonID",
                table: "Invoices",
                column: "ClientPersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_People_ClientPersonID",
                table: "Invoices",
                column: "ClientPersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
