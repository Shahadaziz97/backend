
using Hanan_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Abstractions
{
    public interface IPaymentService
    {
        Task<Payment> GetPaymentByIdAsync(int id);
        Task<IEnumerable<Payment>> GetAllPaymentsAsync();
        Task AddPaymentAsync(Payment payment);
        Task UpdatePaymentAsync(int id, Payment payment);
        Task DeletePaymentAsync(int id);
    }
}