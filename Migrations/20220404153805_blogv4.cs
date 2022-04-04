using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_blog_2022.Migrations
{
    public partial class blogv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimePosted",
                table: "Blog",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimePosted",
                table: "Blog",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }
    }
}
