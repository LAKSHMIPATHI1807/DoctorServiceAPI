using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAvailableTimeSlot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvailableTimeSlot",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableTimeSlot",
                table: "Doctors");
        }
    }
}
