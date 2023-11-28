﻿using static System.Net.Mime.MediaTypeNames;

namespace Domain.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<Test> Tests { get; } = new List<Test>();
        public ICollection<PassedTestData> PassedTestDatas { get; } = new List<PassedTestData>();
    }
}
