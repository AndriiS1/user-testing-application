using Domain.Repositories;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ITestRepository Tests { get; }
        IAnswerRepository Answers { get; }
        IPassedTestDataRepository PassedTestDatas { get; }
        int Complete();
    }
}
