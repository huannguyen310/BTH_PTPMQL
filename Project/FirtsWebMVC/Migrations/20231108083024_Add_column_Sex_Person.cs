using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirtsWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Add_column_Sex_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Persons");
        }
    }
}
