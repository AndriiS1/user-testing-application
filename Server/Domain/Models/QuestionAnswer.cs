using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class QuestionAnswer
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public bool? IsCorrect { get; set; }
        public long? TestQuestionId { get; set; }
        public TestQuestion? TestQuestion { get; set; }
    }
}
