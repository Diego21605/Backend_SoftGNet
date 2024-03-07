using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_SoftGNet.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Vehicles",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Route",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Vehicles",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Route",
                newName: "Descripcion");
        }
    }
}
