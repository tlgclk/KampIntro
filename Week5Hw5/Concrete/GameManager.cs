using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;
using Week5Hw5.Entities;

namespace Week5Hw5.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + "named game added to db");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "named game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Games updated");
        }
    }
}
