namespace Hanan_csharp_backend_teamwork.src.DTOs
{
    public class AddressDTO
    {
        public Guid UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int PostalCode { get; set; }
        public int ZipCode { get; set; }
    }

    // public class AddressReadDTO
    // {
    //     public Guid UserId { get; set; }
    //     public string Country { get; set; }
    //     public string City { get; set; }
    //     public string StreetName { get; set; }
    //     public int PostalCode { get; set; }
    //     public int ZipCode { get; set; }

    // }
}