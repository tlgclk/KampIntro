using System;
using System.Collections.Generic;
using System.Text;

namespace Week5Hw5.Abstract
{
    interface ICampagingService
    {
        void Add(Campagin campagin);
        void Delete(Campagin campagin);
        void Update(Campagin campagin);
    }
}
