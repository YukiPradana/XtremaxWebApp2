
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XtremaxWebApp2.Data.Repository
{
    interface IUserRepository
    {
        IEnumerable<IdentityUser> GetAlluser();
        IdentityUser GetUserById(string id);
    }
}
