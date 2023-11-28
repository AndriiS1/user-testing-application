using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Seeding
{
    public static class DataSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var tests = new List<Test>
            {
                new Test { Id = 1, Title = "Algebra Harvard testing", Category = TestCategory.Math, Description = "The test provided by harvard to deeply test your math knowledge."},
                new Test { Id = 2, Title = "NASA examination", Category = TestCategory.Space, Description = "The NASA examination is a comprehensive assessment designed by the National Aeronautics and Space Administration (NASA) to evaluate your space knowledge."},
                new Test { Id = 3, Title = "WW3Schools test", Category = TestCategory.Programming, Description = "The WW3 Schools Programming Test is a challenging assessment designed to evaluate a programmer's skills and knowledge in various programming languages and concepts.."}
            };
            modelBuilder.Entity<Test>().HasData(tests);

            var testQuestions = new List<TestQuestion>
            {
                new TestQuestion { Id = 1, Title = "Solve for x: 2x+5=11:", TestId = 1 },
                new TestQuestion { Id = 2, Title = "Simplify the expression 3(x+2)−2x:", TestId = 1 },
                new TestQuestion { Id = 3, Title = "Factorize the quadratic expression x^2−5x+6:", TestId = 1 },
                new TestQuestion { Id = 4, Title = "Solve the inequality: 3x+7>1:", TestId = 1 },
                new TestQuestion { Id = 5, Title = "Evaluate the expression 4a^2−2ab+b^2 when a=3 and b=2:", TestId = 1 },

                new TestQuestion { Id = 6, Title = "What is the largest planet in our solar system: ", TestId = 2 },
                new TestQuestion { Id = 7, Title = "Choose many moons does Venus have:", TestId = 2 },
                new TestQuestion { Id = 8, Title = "What is the main component of the Sun:", TestId = 2 },
                new TestQuestion { Id = 9, Title = "Which galaxy is the Milky Way's closest neighbor:", TestId = 2 },
                new TestQuestion { Id = 10, Title = "What is the phenomenon where light is bent as it passes through a gravitational field, predicted by Einstein's theory of General Relativity:", TestId = 2 },

                new TestQuestion { Id = 11, Title = "What does HTML stand for: ", TestId = 3 },
                new TestQuestion { Id = 12, Title = "Which programming language is known for its readability and simplicity:", TestId = 3 },
                new TestQuestion { Id = 13, Title = "What does CSS stand for:", TestId = 3 },
                new TestQuestion { Id = 14, Title = "In object-oriented programming, what is encapsulation:", TestId = 3 },
                new TestQuestion { Id = 15, Title = "What is the purpose of the \"git clone\" command in Git:", TestId = 3 }
            };
            modelBuilder.Entity<TestQuestion>().HasData(testQuestions);

            var questionAnswers = new List<QuestionAnswer>
            {
                new QuestionAnswer { Id = 1, Title = "x=2", IsCorrect = false, TestQuestionId = 1 },
                new QuestionAnswer { Id = 2, Title = "x=3", IsCorrect = true, TestQuestionId = 1 },
                new QuestionAnswer { Id = 3, Title = "x=4", IsCorrect = false, TestQuestionId = 1 },

                new QuestionAnswer { Id = 4, Title = "x+6", IsCorrect = true, TestQuestionId = 2 },
                new QuestionAnswer { Id = 5, Title = "x+4", IsCorrect = false, TestQuestionId = 2 },
                new QuestionAnswer { Id = 6, Title = "x+4", IsCorrect = false, TestQuestionId = 2 },

                new QuestionAnswer { Id = 7, Title = "(x−2)(x−3)", IsCorrect = true, TestQuestionId = 3 },
                new QuestionAnswer { Id = 8, Title = "(x−1)(x−6)", IsCorrect = false, TestQuestionId = 3 },
                new QuestionAnswer { Id = 9, Title = "(x−2)(x−4)", IsCorrect = false, TestQuestionId = 3 },

                new QuestionAnswer { Id = 10, Title = "x>2", IsCorrect = false, TestQuestionId = 4 },
                new QuestionAnswer { Id = 11, Title = "x<3", IsCorrect = false, TestQuestionId = 4 },
                new QuestionAnswer { Id = 12, Title = "x<2", IsCorrect = true, TestQuestionId = 4 },

                new QuestionAnswer { Id = 13, Title = "25", IsCorrect = false, TestQuestionId = 5 },
                new QuestionAnswer { Id = 14, Title = "36", IsCorrect = false, TestQuestionId = 5 },
                new QuestionAnswer { Id = 15, Title = "28", IsCorrect = true, TestQuestionId = 5 },


                new QuestionAnswer { Id = 16, Title = "Earth", IsCorrect = false, TestQuestionId = 6 },
                new QuestionAnswer { Id = 17, Title = "Mars", IsCorrect = false, TestQuestionId = 6 },
                new QuestionAnswer { Id = 18, Title = "Jupiter", IsCorrect = true, TestQuestionId = 6 },

                new QuestionAnswer { Id = 19, Title = "2", IsCorrect = false, TestQuestionId = 7 },
                new QuestionAnswer { Id = 20, Title = "0", IsCorrect = true, TestQuestionId = 7 },
                new QuestionAnswer { Id = 21, Title = "1", IsCorrect = false, TestQuestionId = 7 },

                new QuestionAnswer { Id = 22, Title = "Helium", IsCorrect = false, TestQuestionId = 8 },
                new QuestionAnswer { Id = 23, Title = "Hydrogen", IsCorrect = true, TestQuestionId = 8 },
                new QuestionAnswer { Id = 24, Title = "Oxygen", IsCorrect = false, TestQuestionId = 8 },

                new QuestionAnswer { Id = 25, Title = "M87", IsCorrect = false, TestQuestionId = 9 },
                new QuestionAnswer { Id = 26, Title = "Triangulum", IsCorrect = false, TestQuestionId = 9 },
                new QuestionAnswer { Id = 27, Title = "Andromeda ", IsCorrect = true, TestQuestionId = 9 },

                new QuestionAnswer { Id = 28, Title = "Refraction", IsCorrect = false, TestQuestionId = 10 },
                new QuestionAnswer { Id = 29, Title = "Diffraction", IsCorrect = false, TestQuestionId = 10 },
                new QuestionAnswer { Id = 30, Title = "Gravitational Lensing", IsCorrect = true, TestQuestionId = 10 },


                new QuestionAnswer { Id = 31, Title = "Hyper Transfer Markup Language", IsCorrect = false, TestQuestionId = 11 },
                new QuestionAnswer { Id = 32, Title = "Hyper Text Makeup Language", IsCorrect = false, TestQuestionId = 11 },
                new QuestionAnswer { Id = 33, Title = "Hyper Text Markup Language", IsCorrect = true, TestQuestionId = 11 },

                new QuestionAnswer { Id = 34, Title = "C++", IsCorrect = false, TestQuestionId = 12 },
                new QuestionAnswer { Id = 35, Title = "Java", IsCorrect = false, TestQuestionId = 12 },
                new QuestionAnswer { Id = 36, Title = "Python ", IsCorrect = true, TestQuestionId = 12 },

                new QuestionAnswer { Id = 37, Title = "Computer Style Sheets", IsCorrect = false, TestQuestionId = 13 },
                new QuestionAnswer { Id = 38, Title = "Cascading Style Sheets", IsCorrect = true, TestQuestionId = 13 },
                new QuestionAnswer { Id = 39, Title = "Creative Style Sheets", IsCorrect = false, TestQuestionId = 13 },

                new QuestionAnswer { Id = 40, Title = "Binding the data and the methods that manipulate the data into a single unit", IsCorrect = true, TestQuestionId = 14 },
                new QuestionAnswer { Id = 41, Title = "Breaking down a program into functions", IsCorrect = false, TestQuestionId = 14 },
                new QuestionAnswer { Id = 42, Title = "Connecting two different classes ", IsCorrect = false, TestQuestionId = 14 },

                new QuestionAnswer { Id = 43, Title = "Create a new branch", IsCorrect = false, TestQuestionId = 15 },
                new QuestionAnswer { Id = 44, Title = "Merge branches in Git", IsCorrect = false, TestQuestionId = 15 },
                new QuestionAnswer { Id = 45, Title = "Copy a repository from a remote source to your local machine", IsCorrect = true, TestQuestionId = 15 },
            };
            modelBuilder.Entity<QuestionAnswer>().HasData(questionAnswers);
        }
    }
}
