using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoAsignatura.Migrations
{
    /// <inheritdoc />
    public partial class Uno_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Aulas_AulaId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Profesores_ProfesorId",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "Aula_Id",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "Profesor_Id",
                table: "Asignaturas");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AulaId",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Aulas_AulaId",
                table: "Asignaturas",
                column: "AulaId",
                principalTable: "Aulas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Profesores_ProfesorId",
                table: "Asignaturas",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Aulas_AulaId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Profesores_ProfesorId",
                table: "Asignaturas");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "Asignaturas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AulaId",
                table: "Asignaturas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Aula_Id",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Profesor_Id",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Aulas_AulaId",
                table: "Asignaturas",
                column: "AulaId",
                principalTable: "Aulas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Profesores_ProfesorId",
                table: "Asignaturas",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "Id");
        }
    }
}
