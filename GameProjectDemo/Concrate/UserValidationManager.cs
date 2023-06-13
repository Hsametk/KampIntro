using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrate
{
    internal class UserValidationManager : IUserValitationSevice
    {


        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "Samet" && gamer.LastName == "Kotu" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
