using Galeno.Dominio.Base;
using Galeno.Infraestructura;
using Galeno.Infraestructura.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Galeno.Dominio.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : EntityBase
    {

        public async Task<long> Add(T entity)
        {

            using (var context = new DataContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Deleted;
                        context.Set<T>().Add(entity);
                        await context.SaveChangesAsync();
                        transaction.Commit();
                        return entity.Id;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error occurred: {ex}");

                        return 0;
                    }
                }
            }
        }

        public async Task Delete(T entity)
        {
            using (var context = new DataContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                        context.Entry(entity).State = EntityState.Deleted;
                        context.Set<T>().Remove(entity);
                        await context.SaveChangesAsync();
                        transaction.Commit();
                   
                }
            }
        }

        public async Task Delete(long id)
        {
            using (var context = new DataContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var entidad = context.Set<T>().Find(id);
                        context.Entry(entidad).State = EntityState.Deleted;
                        context.Set<T>().Remove(entidad);
                        await context.SaveChangesAsync();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error occurred: {ex}");

                    }
                }
            }
        }

        public async Task<T> GetById(long id, Func<IQueryable<T>, IQueryable<T>> include = null)
        {
            using (var context = new DataContext())
            {
                IQueryable<T> query = context.Set<T>();
                if (include != null)
                {
                    query = include(query);

                }
                return await query.FirstOrDefaultAsync(x => x.Id == id);
            }
        }

        public async Task<IEnumerable<T>> GetAll(
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IQueryable<T>> include = null)
        {
            using (var context = new DataContext())
            {


                    IQueryable<T> query = context.Set<T>();
                    if (include != null)
                    {
                        query = include(query);

                    }

                    return orderBy != null ?
                        await orderBy(query).ToListAsync() :
                        await query.ToListAsync();
            }
        }

        public async Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IQueryable<T>> include = null)
        {
            using (var context = new DataContext())
            {
                IQueryable<T> query = context.Set<T>();

                if (include != null)
                {
                    query = include(query);
                }

                if (orderBy != null)
                {
                    query = orderBy(query);
                }

                if (predicate != null)
                {
                    query = query.Where(predicate);
                }

                return await query.ToListAsync();
            }
        }

        public async Task Update(T entity)
        {
            using (var context = new DataContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Set<T>().Attach(entity);
                        context.Entry(entity).State = EntityState.Modified;
                        await context.SaveChangesAsync();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error occurred: {ex}");
                    }
                }
            }

        }

    }
}
