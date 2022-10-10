using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestExtraProperties.Migrations
{
    public partial class AddLineManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LineManagerId",
                table: "AbpUsers",
                type: "uuid",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineManagerId",
                table: "AbpUsers");
        }
    }
}
