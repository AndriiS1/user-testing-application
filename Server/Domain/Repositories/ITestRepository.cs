using Domain.Dto;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITestRepository : IRepository<Test>
    {
        Test GetTestsWithRelatedData(long id);
    }
}
