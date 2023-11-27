﻿using Domain.Repositories;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ITestRepository Tests { get; }
        int Complete();
    }
}
