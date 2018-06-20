using System;
using Rocket.DAL.Common.Repositories;

namespace Rocket.DAL.Common.UoW
{
    /// <summary>
    /// Defines the Unit of Work interface.
    /// </summary>
    public interface IStorage : IDisposable
    {
        /// <summary>
        /// Gets the specified repository for the <typeparamref name="TEntity"/>.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>An instance of type inherited from <see cref="IRepository{TEntity}"/> interface.</returns>
        IBaseRepository<TEntity> GetRepository<TEntity>() 
            where TEntity : class;

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        /// <returns>The number of state entries written to the database.</returns>
        int SaveChanges();
    }
}
