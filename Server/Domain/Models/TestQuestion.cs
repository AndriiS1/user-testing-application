using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TestQuestion
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public long? TestId { get; set; }
        public Test? Test { get; set; }
        public ICollection<QuestionAnswer> Answers { get; } = new List<QuestionAnswer>();
    }
}
