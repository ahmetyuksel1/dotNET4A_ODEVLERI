using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserRepository
    {
        Users GetById(int id);

        List<Users> GetAll();

        void Add(Users user);

        void Update(Users user);

        void Delete(Users user);
    }
}
