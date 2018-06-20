using System;
using System.Collections.Generic;
using Rocket.DAL.Common.Repositories;
using Rocket.DAL.Common.UoW;
using Rocket.DAL.Context;
using Rocket.DAL.Repositories;

namespace Rocket.DAL.UoW
{
    /// <summary>
    /// Defines the Unit of Work implementation.
    /// </summary>
    public class Storage : IStorage
    {
        private RocketContext _rocketContext;
        private bool _disposed;
        private Dictionary<Type, object> repositories;

        public Storage(RocketContext rocketContext)
        {
            _rocketContext = rocketContext;
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);
            if (!repositories.ContainsKey(type))
            {
                repositories[type] = new BaseRepository<TEntity>(_rocketContext);
            }

            return (IBaseRepository<TEntity>)repositories[type];
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public int SaveChanges()
        {
            return _rocketContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                GC.SuppressFinalize(this);
            }

            _rocketContext?.Dispose();
            _rocketContext = null;
            _disposed = true;
        }
    }
}
