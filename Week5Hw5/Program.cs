using System;
using Week5Hw5.Entities;
using Week5Hw5.Abstract;
using Week5Hw5.Concrete;


namespace Week5Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            User user1 = new User
            {
                FirstName = "Tolga",
                IdentityNumber = 11111111111,
                LastName = "Çelik",
                DateOfBirth = new DateTime(1996, 1, 1),

            };
           
            userManager.Add(user1);
            userManager.Delete(user1);
            userManager.Update(user1);

            GameManager gameManager = new GameManager();

            Game game = new Game()
            {
                Id = 11,
                Name = "Witcher",
                Price = 33,

            };

            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            CampaginManager campaginManager = new CampaginManager();

            Campagin campagin = new Campagin()
            {
                Discount = 0.1,
                Id = 13,
                Name = "10",
            };

            campaginManager.Add(campagin);
            campaginManager.Delete(campagin);
            campaginManager.Update(campagin);

            SaleManager saleManager = new SaleManager();

            saleManager.Sell(user1, game);
            saleManager.SellWithDiscount(user1, game, campagin);
        }
    }
}
