using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;
using Week5Hw5.Entities;

namespace Week5Hw5.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(User user, Game game)
        {
            Console.WriteLine(game.Name + " sold to: " + user.FirstName + " price :" + game.Price);
        }

        public void SellWithDiscount(User user, Game game, Campagin campagin)
        {
            double DcPrice = (double)(game.Price - (game.Price * campagin.Discount));
            Console.WriteLine(game.Name + " sold to: " + user.FirstName + " discounted price :" + DcPrice);
        }
    }
}
