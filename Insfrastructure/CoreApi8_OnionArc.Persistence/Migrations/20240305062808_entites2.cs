using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreApi8_OnionArc.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class entites2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amoun",
                table: "CarPricings",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "CarPricings",
                newName: "Amoun");
        }
    }
}
