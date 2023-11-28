using Domain.Enums;

namespace Domain.Models
{
    public class Test
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public TestCategory? Category { get; set; }
        public string? Description { get; set; }
        public ICollection<TestQuestion> Questions { get; } = new List<TestQuestion>();
    }
}
