using Domain.Enums;

namespace Domain.Models
{
    public class Test
    {
        public long TestId { get; set; }
        public string? Title { get; set; }
        public TestCategory? Category { get; set; }
        public string? Desription { get; set; }
    }
}
