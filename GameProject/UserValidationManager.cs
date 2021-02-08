using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear == 2002 && gamer.FirstName=="Recep Ali" && gamer.LastName=="Gökmen"&&gamer.IdentityNumber==11111111111)
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
