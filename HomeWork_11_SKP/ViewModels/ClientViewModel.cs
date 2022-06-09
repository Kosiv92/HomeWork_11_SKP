using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    /// <summary>
    /// Модель-представление сущности Клиент
    /// </summary>
    internal class ClientViewModel : BaseViewModel, IClient 
    {
        private IClient _client;

        public string Name { get => _client.Name; set { _client.Name = value; OnPropertyChanged(); }  }
        public string Surname { get => _client.Surname; set { _client.Surname = value; OnPropertyChanged(); } }
        public string Patronymic { get => _client.Patronymic; set { _client.Patronymic = value; OnPropertyChanged(); } }
        public string PhoneNumber { get => _client.PhoneNumber; set { _client.PhoneNumber = value; OnPropertyChanged(); } }
        public long PassportNumber { get => _client.PassportNumber; set { _client.PassportNumber = value; OnPropertyChanged(); } }

        public string ShortSNP { get => _client.Surname + " " + _client.Name[0] + "." + _client.Patronymic[0] + "."; }

        public ClientViewModel(IClient client)
        {
            _client = client;
        }

        #region Methods
        public override string ToString()
        {
            return Surname + " " + Name[0] + "." + Patronymic[0] + ".";
        }

        #endregion
    }
}
