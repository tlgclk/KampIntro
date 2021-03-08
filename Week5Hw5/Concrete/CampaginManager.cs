using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;

namespace Week5Hw5.Concrete
{
    public class CampaginManager : ICampagingService
    {
        public void Add(Campagin campagin)
        {
            Console.WriteLine(campagin.Name + " named campagin added to db. \nDiscount rate is : " + campagin.Discount);
        }

        public void Delete(Campagin campagin)
        {
            Console.WriteLine(campagin.Name + "named campagin deleted");
        }

        public void Update(Campagin campagin)
        {
            Console.WriteLine("Campagins updated");
        }
    }
}
