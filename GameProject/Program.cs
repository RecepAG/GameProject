using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Cyberpunk 2077";
            game1.GamePrice = "300";

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Speed Runner";
            game2.GamePrice = "20";

            Game game3 = new Game();
            game3.Id = 3;
            game3.GameName = "Counter Strike Global Offensive";
            game3.GamePrice = "70";

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                BirthYear = 2002,
                FirstName = "Recep Ali",
                LastName = "Gökmen",
                IdentityNumber = 11111111111,
                CreditCardNumber = 1234567891234567
            };




            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1,
                BirthYear = 2002,
                FirstName = "Recep Ali",
                LastName = "Gökmen",
                IdentityNumber = 11111111111 ,
                CreditCardNumber=1234567891234567});



            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 10;
            campaign1.CampaignName = "Black Friday";
            campaign1.Discount = "%50";

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign1);
            campaignService.Delete(campaign1);
            campaignService.Update(campaign1);

            Sales sales1 = new Sales() { GameName = game1.GameName, GamerName = gamer1.FirstName };

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game3, gamer1);
            salesManager.Buy(game1, gamer1);



        }
    }
}
