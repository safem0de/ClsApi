namespace ClsApi.Domain.Interfaces.Respositories
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetByEmpNoAsync(int id);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Employee employee);
    }
}