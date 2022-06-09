using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    public abstract class User
    {
        private AccessLevel _userAccessLevel;

        public AccessLevel UserAccessLevel
        {
            get => _userAccessLevel;
            set => _userAccessLevel = value;            
        }

        //public override string ToString()
        //{
        //    if(_userAccessLevel == AccessLevel.Сonsultant) return "Уровень доступа - Консультант";
        //    else return "Уровень доступа - Менеджер";
        //}
    }
}
