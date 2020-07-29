using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Galeno.Dominio.Base
{
    public interface IRepositorio<T>
    {
        Task<long> Add(T entity);

        Task Delete(T entity);

        Task Delete(long id);

        Task Update(T entity);

        Task<T> GetById(long id,
            Func<IQueryable<T>, IQueryable<T>> include = null);

        Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IQueryable<T>> include = null);

        Task<IEnumerable<T>> GetByFilter(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IQueryable<T>> include = null);
    }
}
