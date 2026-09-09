using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPlacementDetailsToProvisionalReceipt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "placement_control_number",
                table: "filpride_provisional_receipts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "td_account_number",
                table: "filpride_provisional_receipts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "placement_control_number",
                table: "filpride_provisional_receipts");

            migrationBuilder.DropColumn(
                name: "td_account_number",
                table: "filpride_provisional_receipts");
        }
    }
}
