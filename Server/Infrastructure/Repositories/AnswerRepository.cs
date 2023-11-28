using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AnswerRepository : Repository<QuestionAnswer>, IAnswerRepository
    {
        public AnswerRepository(DbContext context) : base(context)
        {

        }
    }
}
