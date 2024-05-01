using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<UserReadDto> FindAll();
        public User CreateOne(User user);
        public UserReadDto? FindOneByEmail(string email);
        public User UpdateOne(string email, User newValue); 
    }
}