using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACMS_ONLINE_INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class AddImagepathcolum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PathImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathImage",
                table: "AspNetUsers");
        }
    }
}
