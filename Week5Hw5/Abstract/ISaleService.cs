using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Entities;

namespace Week5Hw5.Abstract
{
    interface ISaleService
    {
        void Sell(User user, Game game);
        void SellWithDiscount(User user, Game game, Campagin campagin);

    }
}
