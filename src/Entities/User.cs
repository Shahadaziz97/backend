namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class User
{
    public User( string fullName, string email, string password,string countryCode, string phone, string role)
    {
        FullName = fullName;
        Email = email;
        Password = password;
        CountryCode = countryCode;
        Phone = phone;
        Role = role;
    }

    //public string id { get;} = Guid.NewGuid().ToString();

    public Guid Id { get; set;}= Guid.NewGuid();
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CountryCode { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }

}
