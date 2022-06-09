using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    internal class Consultant : User
    {
        public Consultant()
        { UserAccessLevel = AccessLevel.Сonsultant; }

        public override string ToString()
        {
            return "Консультант";
        }
    }
}
