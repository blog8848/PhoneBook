using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PhoneBook.Data.Infrastructures
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Retrieve Single item filtered by primary key.
        /// </summary>
        /// <param name="primaryKey">primary key of record.</param>
        /// <returns>T</returns>
        T Single(object primaryKey);

        /// <summary>
        /// Return all rows for type T
        /// </summary>
        /// <returns>Collection of rows</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Inserts entities in database.
        /// </summary>
        /// <param name="entity">Entity to insert.</param>
        /// <returns>Primary key of inserted entity.</returns>
        void Insert(T entity);

        /// <summary>
        /// Updates entities in database.
        /// </summary>
        /// <param name="entity">Entity to update</param>
        void Update(T entity);

        /// <summary>
        /// Deletes this item from database.
        /// Usually data should not be deleted instead its status should be changed.
        /// </summary>
        /// <param name="entity">Entity to be deleted.</param>
        /// <returns></returns>
        void Delete(T entity);

        bool Exists(Expression<Func<T, bool>> where);

    }
}
