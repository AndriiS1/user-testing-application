using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "Password", "RefreshToken", "RefreshTokenExpiryTime", "SecondName" },
                values: new object[] { 1L, "john.doe@example.com", "John", "password123", null, null, "Doe" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Desription", "Title", "UserId" },
                values: new object[] { 1L, 2, "The test provided by harvard to deeply test your math knowledge", "Algebra Harvard testing", 1L });

            migrationBuilder.InsertData(
                table: "TestQuestions",
                columns: new[] { "Id", "TestId", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, "2x+5=11:" },
                    { 2L, 1L, "Simplify the expression 3(x+2)−2x:" },
                    { 3L, 1L, "Factorize the quadratic expression x^2−5x+6:" },
                    { 4L, 1L, "Solve the inequality: 3x+7>1:" },
                    { 5L, 1L, "Evaluate the expression 4a^2−2ab+b^2 when a=3 and b=2:" }
                });

            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "Id", "IsCorrect", "TestQuestionId", "Title" },
                values: new object[,]
                {
                    { 1L, false, 1L, "x=2" },
                    { 2L, false, 1L, "x=3" },
                    { 3L, true, 1L, "x=4" },
                    { 4L, false, 2L, "x+6" },
                    { 5L, true, 2L, "x+4" },
                    { 6L, false, 2L, "x+4" },
                    { 7L, true, 3L, "(x−2)(x−3)" },
                    { 8L, false, 3L, "(x−1)(x−6)" },
                    { 9L, false, 3L, "(x−2)(x−4)" },
                    { 10L, true, 4L, "x>2" },
                    { 11L, false, 4L, "x<2" },
                    { 12L, false, 4L, "x<3" },
                    { 13L, false, 5L, "25" },
                    { 14L, false, 5L, "36" },
                    { 15L, true, 5L, "16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
