using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Entities;

namespace Week5Hw5.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
