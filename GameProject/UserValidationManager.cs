using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidService
    {
        public bool Validation(Gamer gamer)
        {
            if(gamer.DogumYili == 1985 && gamer.Adi == "semih")
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
