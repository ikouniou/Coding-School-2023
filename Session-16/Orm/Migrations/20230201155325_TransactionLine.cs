using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class TransactionLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Transactions_TransactionID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Car_CarID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customer_CustomerID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Manager_ManagerID",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_ManagerID",
                table: "Transaction",
                newName: "IX_Transaction_ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transaction",
                newName: "IX_Transaction_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CarID",
                table: "Transaction",
                newName: "IX_Transaction_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_EngineerID",
                table: "TransactionLine",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_ServiceTaskID",
                table: "TransactionLine",
                column: "ServiceTaskID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Car_CarID",
                table: "Transaction",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Manager_ManagerID",
                table: "Transaction",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Engineer_EngineerID",
                table: "TransactionLine",
                column: "EngineerID",
                principalTable: "Engineer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_ServiceTask_ServiceTaskID",
                table: "TransactionLine",
                column: "ServiceTaskID",
                principalTable: "ServiceTask",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Transaction_TransactionID",
                table: "TransactionLine",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Car_CarID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Manager_ManagerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Engineer_EngineerID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_ServiceTask_ServiceTaskID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Transaction_TransactionID",
                table: "TransactionLine");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLine_EngineerID",
                table: "TransactionLine");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLine_ServiceTaskID",
                table: "TransactionLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_ManagerID",
                table: "Transactions",
                newName: "IX_Transactions_ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transactions",
                newName: "IX_Transactions_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_CarID",
                table: "Transactions",
                newName: "IX_Transactions_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Transactions_TransactionID",
                table: "TransactionLine",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Car_CarID",
                table: "Transactions",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customer_CustomerID",
                table: "Transactions",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Manager_ManagerID",
                table: "Transactions",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
