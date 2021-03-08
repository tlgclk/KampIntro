using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using Week5Hw5.Abstract;
using Week5Hw5.Entities;

namespace Week5Hw5.Adapters
{
    class MernisServiceAdapter : IUserCheckService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.IdentityNumber), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year);
        }
    }
}
