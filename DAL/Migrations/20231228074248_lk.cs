using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class lk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "TC",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Yas",
                table: "Kullanicilar");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Kullanicilar",
                newName: "Sifre");

            migrationBuilder.RenameColumn(
                name: "Cinsiyet",
                table: "Kullanicilar",
                newName: "KullaniciAdi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sifre",
                table: "Kullanicilar",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "KullaniciAdi",
                table: "Kullanicilar",
                newName: "Cinsiyet");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TC",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Telefon",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yas",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
