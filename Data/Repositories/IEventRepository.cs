using Data.Entities;
using Data.Models;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public interface IEventRepository
    {
        Task<RepositoryResult<IEnumerable<EventEntity>>> GetAllAsync(EventEntity entity);
        Task<RepositoryResult<EventEntity?>> GetAsync(Expression<Func<EventEntity, bool>> expression);
    }
}