using MusicSite.Models.EntityModels;
using MusicSite.Services.RepositoryService;
using System;

namespace MusicSite.Services.UnitOfWorkService
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        void SaveChanges();
    }
}