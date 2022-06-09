using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    internal class Client : IClient
    {
        #region Fields

        private string _name;

        private string _surname;

        private string _patronymic;

        private string _phoneNumber;

        private long _passportNumber;

        #endregion

        #region Properties

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get => _surname; set => _surname = value; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get => _patronymic; set => _patronymic = value; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
      
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public long PassportNumber { get => _passportNumber; set => _passportNumber = value; }        

        #endregion

        #region Methods
        public override string ToString()
        {
            return Surname + " " + Name[0] + "." + Patronymic[0] + ".";
        }

        #endregion



    }
}
