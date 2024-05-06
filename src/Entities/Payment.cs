using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentStatus Status { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Assuming a one-to-many relationship with User entity
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed
    }

}
