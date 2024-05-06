using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid AddressID { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalAmount { get; set; }
    public string Status { get; set; }
    public string Payment { get; set; }
    public IEnumerable<OrderItem> OrderItem { get; set; }



}
