using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemo2.Migrations
{
    public partial class v2addmodels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_People_PersonID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Invoices",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_PersonID",
                table: "Invoices",
                newName: "IX_Invoices_ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_People_ClientID",
                table: "Invoices",
                column: "ClientID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_People_ClientID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Invoices",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ClientID",
                table: "Invoices",
                newName: "IX_Invoices_PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_People_PersonID",
                table: "Invoices",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
