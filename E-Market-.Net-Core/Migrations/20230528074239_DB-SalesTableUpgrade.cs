using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Market_.Net_Core.Migrations
{
    /// <inheritdoc />
    public partial class DBSalesTableUpgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currents_Sales_SalesId",
                table: "Currents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sales_SalesId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SalesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalesId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Currents_SalesId",
                table: "Currents");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "Currents");

            migrationBuilder.AddColumn<int>(
                name: "CurrentId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProducsProductId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CurrentId",
                table: "Sales",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProducsProductId",
                table: "Sales",
                column: "ProducsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Currents_CurrentId",
                table: "Sales",
                column: "CurrentId",
                principalTable: "Currents",
                principalColumn: "CurrentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Employees_EmployeeId",
                table: "Sales",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProducsProductId",
                table: "Sales",
                column: "ProducsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Currents_CurrentId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Employees_EmployeeId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProducsProductId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CurrentId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProducsProductId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CurrentId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ProducsProductId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "SalesId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesId",
                table: "Currents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SalesId",
                table: "Products",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesId",
                table: "Employees",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Currents_SalesId",
                table: "Currents",
                column: "SalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Currents_Sales_SalesId",
                table: "Currents",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "SalesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sales_SalesId",
                table: "Employees",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "SalesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SalesId",
                table: "Products",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "SalesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
