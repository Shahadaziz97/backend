using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
    private List<User> _users;

//IEnumerable
    public UserRepository()
    {
        _users = new DatabaseContext().users;
    }

    public List<User> FindAll()
    {
        return _users;
    }

    public User CreateOne(User user)
    {
        _users.Add(user);
        return user;
    }
    public User? FindOneByEmail(string email)
    {
        User? user = _users.FirstOrDefault(user => user.Email == email);
        return user;
    }

    public User UpdateOne(User updateUser)
    {
       var users =  _users.Select(user => {
            if(user.Email == updateUser.Email)
            {
                return updateUser;
            }
            return user;
        });
        _users = users.ToList();

        return updateUser;
    }



    //     public User? FindOneById(string id)
    // {
    //     User? user = _users.FirstOrDefault(user => user.Id == id);
    //     return user;
    // }


}
