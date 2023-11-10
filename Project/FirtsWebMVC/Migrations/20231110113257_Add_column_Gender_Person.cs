using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirtsWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Add_column_Gender_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Person");
        }
    }
}
