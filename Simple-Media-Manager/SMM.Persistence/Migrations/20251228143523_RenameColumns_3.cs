using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumns_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "medias",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "medias",
                newName: "Id");
        }
    }
}
