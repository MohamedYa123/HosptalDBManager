using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBManager.Migrations
{
    /// <inheritdoc />
    public partial class db4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_position_positionid",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_position",
                table: "position");

            migrationBuilder.RenameTable(
                name: "position",
                newName: "positions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_positions",
                table: "positions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_positions_positionid",
                table: "users",
                column: "positionid",
                principalTable: "positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_positions_positionid",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_positions",
                table: "positions");

            migrationBuilder.RenameTable(
                name: "positions",
                newName: "position");

            migrationBuilder.AddPrimaryKey(
                name: "PK_position",
                table: "position",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_position_positionid",
                table: "users",
                column: "positionid",
                principalTable: "position",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
