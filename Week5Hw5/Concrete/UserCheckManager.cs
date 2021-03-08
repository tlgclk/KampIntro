using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;
using Week5Hw5.Entities;

namespace Week5Hw5.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}
