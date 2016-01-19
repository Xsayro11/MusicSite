using System;
using System.Data.Entity;

namespace MusicSite.DAL
{
    public interface IContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}