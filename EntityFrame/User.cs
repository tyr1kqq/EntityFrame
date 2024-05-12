using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City {  get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }

        public int CompanyId {  get; set; }

        public Company Company { get; set; }
    }

    public class  Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; } = new List<User> ();
    }

    public class UserCredential
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // Внешний ключ 
        public int UserId {  get; set; }
         // Навигационое свойство
         public User User { get; set; }
    }
}
