using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    internal class Manager : User
    {
        public Manager()
        {
            UserAccessLevel = AccessLevel.Manager;
        }

        public override string ToString()
        {
            return "Менеджер";
        }

    }
}
