using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

public class DatabaseContext
{
    public List<Category> categorys;
    public List<User> users;

    public DatabaseContext()
    {
        categorys = [
            new Category("1","phone"),
                new Category("2","laptop"),
                new Category("3","heedPhone")
        ];
        users = [
            new User("shahd Al","hhh@gmail.com","212n12","+966","444444444",""),
                new User("deem Al","dd@gmail.com","13b1313","+966","777777777",""),
                new User("mohannad Al","mm@gmail.com","14b1414","+966","8888888888","")
        ];
    }
}
