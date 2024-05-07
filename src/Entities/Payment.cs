using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentStatus Status { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        public Guid UserId { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed
    }

}
