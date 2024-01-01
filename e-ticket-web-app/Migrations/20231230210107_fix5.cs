using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_ticket_web_app.Migrations
{
    /// <inheritdoc />
    public partial class fix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Actor_Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Actor_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
