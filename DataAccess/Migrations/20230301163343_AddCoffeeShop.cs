using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCoffeeShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('Nhi Coffee', '9-5 Mon-Sat', 'HCM')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('HN Coffee', '9-5 Mon-Sat', 'HN')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('QT Coffee', '9-5 Mon-Sat', 'QT')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('CN Coffee', '9-5 Mon-Sat', 'CN')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('UK Coffee', '9-5 Mon-Sat', 'UK')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address) Values ('US Coffee', '9-5 Mon-Sat', 'US')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
