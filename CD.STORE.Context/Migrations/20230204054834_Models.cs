using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CD.STORE.Context.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "inv");

            migrationBuilder.EnsureSchema(
                name: "usm");

            migrationBuilder.EnsureSchema(
                name: "sm");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "inv",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "usm",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "usm",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                schema: "sm",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "SalesDocumentNumber",
                schema: "sm",
                columns: table => new
                {
                    SalesDocumentNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDocumentNumber", x => x.SalesDocumentNumberId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "inv",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "inv",
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                schema: "usm",
                columns: table => new
                {
                    MenuRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => x.MenuRoleId);
                    table.ForeignKey(
                        name: "FK_MenuRole_Menu_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "usm",
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "usm",
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "usm",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "usm",
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetail",
                schema: "sm",
                columns: table => new
                {
                    SaleDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInsId = table.Column<long>(type: "bigint", nullable: false),
                    InsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdaId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDelId = table.Column<long>(type: "bigint", nullable: false),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetail", x => x.SaleDetailId);
                    table.ForeignKey(
                        name: "FK_SaleDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "inv",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDetail_Sale_SaleId",
                        column: x => x.SaleId,
                        principalSchema: "sm",
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MenuId",
                schema: "usm",
                table: "MenuRole",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RoleId",
                schema: "usm",
                table: "MenuRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "inv",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_ProductId",
                schema: "sm",
                table: "SaleDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_SaleId",
                schema: "sm",
                table: "SaleDetail",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                schema: "usm",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRole",
                schema: "usm");

            migrationBuilder.DropTable(
                name: "SaleDetail",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "SalesDocumentNumber",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "User",
                schema: "usm");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "usm");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "inv");

            migrationBuilder.DropTable(
                name: "Sale",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "usm");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "inv");
        }
    }
}
