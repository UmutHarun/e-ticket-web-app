using e_ticket_web_app.Models;
using System.Linq.Expressions;

namespace e_ticket_web_app.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class , IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProporties);

        Task<T> GetByID(int id);

        Task Add(T entity);

        Task Update(int id, T entity);

        Task Delete(int id);
    }
}
