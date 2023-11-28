using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Title",
                value: "x<3");

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IsCorrect", "Title" },
                values: new object[] { true, "x<2" });

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Title",
                value: "28");

            migrationBuilder.UpdateData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Title",
                value: "Solve for x: 2x+5=11:");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "The test provided by harvard to deeply test your math knowledge.");

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 2L, 0, "The NASA examination is a comprehensive assessment designed by the National Aeronautics and Space Administration (NASA) to evaluate your space knowledge.", "NASA examination", null },
                    { 3L, 1, "The WW3 Schools Programming Test is a challenging assessment designed to evaluate a programmer's skills and knowledge in various programming languages and concepts..", "WW3Schools test", null }
                });

            migrationBuilder.InsertData(
                table: "TestQuestions",
                columns: new[] { "Id", "TestId", "Title" },
                values: new object[,]
                {
                    { 6L, 2L, "What is the largest planet in our solar system: " },
                    { 7L, 2L, "Choose many moons does Venus have:" },
                    { 8L, 2L, "What is the main component of the Sun:" },
                    { 9L, 2L, "Which galaxy is the Milky Way's closest neighbor:" },
                    { 10L, 2L, "What is the phenomenon where light is bent as it passes through a gravitational field, predicted by Einstein's theory of General Relativity:" },
                    { 11L, 3L, "What does HTML stand for: " },
                    { 12L, 3L, "Which programming language is known for its readability and simplicity:" },
                    { 13L, 3L, "What does CSS stand for:" },
                    { 14L, 3L, "In object-oriented programming, what is encapsulation:" },
                    { 15L, 3L, "What is the purpose of the \"git clone\" command in Git:" }
                });

            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "Id", "IsCorrect", "TestQuestionId", "Title" },
                values: new object[,]
                {
                    { 16L, false, 6L, "Earth" },
                    { 17L, false, 6L, "Mars" },
                    { 18L, true, 6L, "Jupiter" },
                    { 19L, false, 7L, "2" },
                    { 20L, true, 7L, "0" },
                    { 21L, false, 7L, "1" },
                    { 22L, false, 8L, "Helium" },
                    { 23L, true, 8L, "Hydrogen" },
                    { 24L, false, 8L, "Oxygen" },
                    { 25L, false, 9L, "M87" },
                    { 26L, false, 9L, "Triangulum" },
                    { 27L, true, 9L, "Andromeda " },
                    { 28L, false, 10L, "Refraction" },
                    { 29L, false, 10L, "Diffraction" },
                    { 30L, true, 10L, "Gravitational Lensing" },
                    { 31L, false, 11L, "Hyper Transfer Markup Language" },
                    { 32L, false, 11L, "Hyper Text Makeup Language" },
                    { 33L, true, 11L, "Hyper Text Markup Language" },
                    { 34L, false, 12L, "C++" },
                    { 35L, false, 12L, "Java" },
                    { 36L, true, 12L, "Python " },
                    { 37L, false, 13L, "Computer Style Sheets" },
                    { 38L, true, 13L, "Cascading Style Sheets" },
                    { 39L, false, 13L, "Creative Style Sheets" },
                    { 40L, true, 14L, "Binding the data and the methods that manipulate the data into a single unit" },
                    { 41L, false, 14L, "Breaking down a program into functions" },
                    { 42L, false, 14L, "Connecting two different classes " },
                    { 43L, false, 15L, "Create a new branch" },
                    { 44L, false, 15L, "Merge branches in Git" },
                    { 45L, true, 15L, "Copy a repository from a remote source to your local machine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "IsCorrect",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "IsCorrect",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Title",
                value: "x<2");

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IsCorrect", "Title" },
                values: new object[] { false, "x<3" });

            migrationBuilder.UpdateData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Title",
                value: "16");

            migrationBuilder.UpdateData(
                table: "TestQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Title",
                value: "2x+5=11:");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "The test provided by harvard to deeply test your math knowledge");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "Password", "RefreshToken", "RefreshTokenExpiryTime", "SecondName" },
                values: new object[] { 1L, "john.doe@example.com", "John", "password123", null, null, "Doe" });
        }
    }
}
