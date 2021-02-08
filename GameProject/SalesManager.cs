using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+gamer.LastName+ " adlı kullanıcı "+ game.GameName +" adlı oyunu satın aldı.");
        }
    }
}
