using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepositoryAsyncEntityFramework
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        T Add(T t);
        Task<T> AddAsync(T t);
        int Count();
        Task<int> CountAsync();
        void Delete(T t);
        Task<int> DeleteAsync(T t);
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        T Get(int id);
        ICollection<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        T Update(T updated, int key);
        Task<T> UpdateAsync(T updated, int key);
    }
}