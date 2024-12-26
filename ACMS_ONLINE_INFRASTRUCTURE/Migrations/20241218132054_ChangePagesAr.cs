using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACMS_ONLINE_INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ChangePagesAr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Pages",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Pages",
                newName: "Name");
        }
    }
}
