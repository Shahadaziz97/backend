
using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;

public class OrderCreateDTO
{
    public Guid AddressID { get; set; }
    public Guid UserId { get; set; }
    public int TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public string Status { get; set; }
    [Required]
    public string Payment { get; set; }

}

public class CheckoutDto
{
    public Guid ProductId { get; set; }
    public string Color { get; set; }
    public char Size { get; set; }
    public int Quantity { get; set; }
}
public class OrderReadDto
{
    public Guid Id { get; set; }
    public Guid AddressID { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalAmount { get; set; }
    public string Status { get; set; }
    public string Payment { get; set; }



}