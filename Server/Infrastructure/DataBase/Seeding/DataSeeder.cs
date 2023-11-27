using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Seeding
{
    public static class DataSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var users = new List<User>
            {
            new User { Id = 1, FirstName = "John", SecondName = "Doe", Email = "john.doe@example.com", Password = "password123" }
            };
            modelBuilder.Entity<User>().HasData(users);


            var tests = new List<Test>
            {
                new Test { Id = 1, Title = "Algebra Harvard testing", Category = TestCategory.Math, Desription = "The test provided by harvard to deeply test your math knowledge", UserId = 1 }
            };
            modelBuilder.Entity<Test>().HasData(tests);

            var testQuestions = new List<TestQuestion>
            {
                new TestQuestion { Id = 1, Title = "2x+5=11:", TestId = 1 },
                new TestQuestion { Id = 2, Title = "Simplify the expression 3(x+2)−2x:", TestId = 1 },
                new TestQuestion { Id = 3, Title = "Factorize the quadratic expression x^2−5x+6:", TestId = 1 },
                new TestQuestion { Id = 4, Title = "Solve the inequality: 3x+7>1:", TestId = 1 },
                new TestQuestion { Id = 5, Title = "Evaluate the expression 4a^2−2ab+b^2 when a=3 and b=2:", TestId = 1 }
            };
            modelBuilder.Entity<TestQuestion>().HasData(testQuestions);

            var questionAnswers = new List<QuestionAnswer>
            {
                new QuestionAnswer { Id = 1, Title = "x=2", IsCorrect = false, TestQuestionId = 1 },
                new QuestionAnswer { Id = 2, Title = "x=3", IsCorrect = false, TestQuestionId = 1 },
                new QuestionAnswer { Id = 3, Title = "x=4", IsCorrect = true, TestQuestionId = 1 },

                new QuestionAnswer { Id = 4, Title = "x+6", IsCorrect = false, TestQuestionId = 2 },
                new QuestionAnswer { Id = 5, Title = "x+4", IsCorrect = true, TestQuestionId = 2 },
                new QuestionAnswer { Id = 6, Title = "x+4", IsCorrect = false, TestQuestionId = 2 },

                new QuestionAnswer { Id = 7, Title = "(x−2)(x−3)", IsCorrect = true, TestQuestionId = 3 },
                new QuestionAnswer { Id = 8, Title = "(x−1)(x−6)", IsCorrect = false, TestQuestionId = 3 },
                new QuestionAnswer { Id = 9, Title = "(x−2)(x−4)", IsCorrect = false, TestQuestionId = 3 },

                new QuestionAnswer { Id = 10, Title = "x>2", IsCorrect = true, TestQuestionId = 4 },
                new QuestionAnswer { Id = 11, Title = "x<2", IsCorrect = false, TestQuestionId = 4 },
                new QuestionAnswer { Id = 12, Title = "x<3", IsCorrect = false, TestQuestionId = 4 },

                new QuestionAnswer { Id = 13, Title = "25", IsCorrect = false, TestQuestionId = 5 },
                new QuestionAnswer { Id = 14, Title = "36", IsCorrect = false, TestQuestionId = 5 },
                new QuestionAnswer { Id = 15, Title = "16", IsCorrect = true, TestQuestionId = 5 },
            };

            modelBuilder.Entity<QuestionAnswer>().HasData(questionAnswers);
        }
    }
}
