using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;

namespace Week5Hw5.Entities
{
    public class Game : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
