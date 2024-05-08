using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hanan_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid AddressId { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalAmount { get; set; }
    public Status Status { get; set; }
    public Guid PaymentId { get; set; }
    // // public IEnumerable<OrderItem> OrderItem { get; set; }
    // public IEnumerable<User> Users { get; set; }
    // public IEnumerable<Address> Addresses { get; set; }
    public IEnumerable<OrderItem> OrderItems { get; set; }





}
