using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departament.Data.Entitys.User
{
    public class User : IdentityUser, IUser
    {
        public string Login { get; set; }
    }
}
