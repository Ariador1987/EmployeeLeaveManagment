namespace EmployeeLeaveManagment.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int id);
        Task<T> GetByIdAsync(int? id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

    }
}
