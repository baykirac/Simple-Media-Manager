using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_folders_folders_ParentId",
                table: "folders");

            migrationBuilder.DropForeignKey(
                name: "FK_medias_folders_FolderId",
                table: "medias");

            migrationBuilder.RenameColumn(
                name: "MediaUrl",
                table: "medias",
                newName: "media_url");

            migrationBuilder.RenameColumn(
                name: "MediaName",
                table: "medias",
                newName: "media_name");

            migrationBuilder.RenameColumn(
                name: "FolderId",
                table: "medias",
                newName: "folder_id");

            migrationBuilder.RenameIndex(
                name: "IX_medias_FolderId",
                table: "medias",
                newName: "IX_medias_folder_id");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "folders",
                newName: "parent_id");

            migrationBuilder.RenameIndex(
                name: "IX_folders_ParentId",
                table: "folders",
                newName: "IX_folders_parent_id");

            migrationBuilder.AlterColumn<long>(
                name: "parent_id",
                table: "folders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_folders_folders_parent_id",
                table: "folders",
                column: "parent_id",
                principalTable: "folders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_medias_folders_folder_id",
                table: "medias",
                column: "folder_id",
                principalTable: "folders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_folders_folders_parent_id",
                table: "folders");

            migrationBuilder.DropForeignKey(
                name: "FK_medias_folders_folder_id",
                table: "medias");

            migrationBuilder.RenameColumn(
                name: "media_url",
                table: "medias",
                newName: "MediaUrl");

            migrationBuilder.RenameColumn(
                name: "media_name",
                table: "medias",
                newName: "MediaName");

            migrationBuilder.RenameColumn(
                name: "folder_id",
                table: "medias",
                newName: "FolderId");

            migrationBuilder.RenameIndex(
                name: "IX_medias_folder_id",
                table: "medias",
                newName: "IX_medias_FolderId");

            migrationBuilder.RenameColumn(
                name: "parent_id",
                table: "folders",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_folders_parent_id",
                table: "folders",
                newName: "IX_folders_ParentId");

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "folders",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_folders_folders_ParentId",
                table: "folders",
                column: "ParentId",
                principalTable: "folders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_medias_folders_FolderId",
                table: "medias",
                column: "FolderId",
                principalTable: "folders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
