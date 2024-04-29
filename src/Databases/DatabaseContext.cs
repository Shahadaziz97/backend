using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;

    public class DatabaseContext
    {

        public List<Category> categorys;

        public DatabaseContext()
        {
            categorys = [
                new Category("1","phone"),
                new Category("2","laptop"),
                new Category("3","heedPhone")
            ];
        }
    }
