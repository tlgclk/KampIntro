using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;
using Week5Hw5.Entities;

namespace Week5Hw5.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine("New user added : " + user.FirstName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("User deleted : " + user.FirstName);
        }

        public void Update(User user)
        {
            Console.WriteLine("Users updated");
        }
    }
}
