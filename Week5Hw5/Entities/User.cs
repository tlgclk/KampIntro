using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;

namespace Week5Hw5.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long IdentityNumber { get; set; }

    }
}
