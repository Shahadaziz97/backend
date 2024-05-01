namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class User
{
    public User(string id, string full_name, string email, string password,string country_code, string phone, string role)
    {
        Id = id;
        Full_name = full_name;
        Email = email;
        Password = password;
        Country_code = country_code;
        Phone = phone;
        Role = role;
    }

    //public string id { get;} = Guid.NewGuid().ToString();

    public string Id { get; set;}
    public string Full_name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Country_code { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }

}
