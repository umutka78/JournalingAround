using Microsoft.EntityFrameworkCore.Migrations;

namespace JournalingAround.DataLayer.Migrations.PartyRepositoryMigrations
{
    public partial class added_organisationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OrganisationName = table.Column<string>(nullable: true),
                    TaxId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organisations_Parties_Id",
                        column: x => x.Id,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organisations");
        }
    }
}
