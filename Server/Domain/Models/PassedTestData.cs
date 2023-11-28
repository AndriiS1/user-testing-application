using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PassedTestData
    {
        public long Id { get; set; }
        public double? Mark { get; set; }
        public long? TestId { get; set; }
        public Test? Test { get; set; }
        public long? UserId { get; set; }
        public User? User { get; set; }
    }
}
