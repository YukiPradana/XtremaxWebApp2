using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XtremaxWebApp2.Data.Repository
{

    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<IdentityUser> GetAlluser()
        {
           return _context.Users.ToList();
        }

        public IdentityUser GetUserById(string id)
        {
           return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
