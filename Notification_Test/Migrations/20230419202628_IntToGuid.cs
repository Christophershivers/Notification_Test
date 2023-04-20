using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notification_Test.Migrations
{
    public partial class IntToGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                    name: "PK_Notifications",
                    table: "Notifications");

            migrationBuilder.AddColumn<Guid>(
                    name: "gId",
                    table: "Notifications",
                    nullable: false,
                    defaultValue: Guid.NewGuid());

            migrationBuilder.DropColumn(
                   name: "id",
                   table: "Notifications");

            migrationBuilder.RenameColumn(
                    name: "gId",
                    table: "Notifications",
                    newName: "id");

            migrationBuilder.AddPrimaryKey(
                    name: "PK_Notifications",
                    table: "Notifications",
                    column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                    name: "PK_Notifications",
                    table: "Notifications");

            migrationBuilder.AddColumn<int>(
                    name: "TempId",
                    table: "Notifications",
                    nullable: false,
                    defaultValue: 0)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            
            migrationBuilder.DropColumn(
                    name: "id",
                    table: "Notifications");

            
            migrationBuilder.RenameColumn(
                    name: "TempId",
                    table: "Notifications",
                    newName: "id");

            migrationBuilder.AddPrimaryKey(
                    name: "PK_Notifications",
                    table: "Notifications",
                    column: "id");
        }
    }
    
}
