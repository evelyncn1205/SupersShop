using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IGenericRepository<T> where T : class     
    {
        IQueryable<T> GetAll();   //método que devolve todas as entidades utilizadas pelo "T"


        Task<T> GetByIdAsync(int id);

        Task CreatAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task <bool> ExistAsync(int id); 
    }
}
