using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        //this is like a contract, that any class will use what is defined in here
        string CreateToken(AppUser user);
    }
}