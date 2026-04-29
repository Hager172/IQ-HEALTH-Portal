using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACMS_ONLINE_INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class addcolumnIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "IsActive",
                table: "OnlineClients",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "OnlineClients");
        }
    }
}
