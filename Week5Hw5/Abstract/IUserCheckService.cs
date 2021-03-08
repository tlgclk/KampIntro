using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Entities;

namespace Week5Hw5.Abstract
{
    interface IUserCheckService
    {
        bool Validate(User user);
    }
}
