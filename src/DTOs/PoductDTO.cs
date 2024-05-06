using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class PoductReadDTO
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}