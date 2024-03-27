using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Users : BaseEntity
    {
        public Users()
        {
            
        }

        public Users(int id, string name, string email, string phone, string address, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            Password = password;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }
    }
}
