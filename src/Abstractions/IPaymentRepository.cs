using Hanan_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Abstractions
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByIdAsync(int id);
        Task<IEnumerable<Payment>> GetAllAsync();
        Task AddAsync(Payment payment);
        Task UpdateAsync(Payment payment);
        Task DeleteAsync(int id);
    }
}