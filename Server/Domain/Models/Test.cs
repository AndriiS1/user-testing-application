using Domain.Enums;

namespace Domain.Models
{
    public class Test
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public TestCategory? Category { get; set; }
        public string? Desription { get; set; }
        public long? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<TestQuestion> Questions { get; } = new List<TestQuestion>();
    }
}
