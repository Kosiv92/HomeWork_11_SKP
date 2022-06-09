using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeWork_11_SKP
{
    internal class MainViewModel : BaseViewModel
    {
        #region Fields

        private User _appUser;

        private ICommand _setAccessLevel;

        private IClient selectedClient;

        //private ClientManager _clientManager;

        #endregion

        #region Properties

        public User AppUser
        {
            get { return _appUser; }
            set { _appUser = value;
                OnPropertyChanged();}
        }
        
        /// <summary>
        /// Уровень доступа к данным клиентов в приложении
        /// </summary>
        //public AccessLevel UserAccessLevel
        //{
        //    get => _user.UserAccessLevel;
        //    set
        //    {
        //        _user.UserAccessLevel = value;
        //        OnPropertyChanged();
        //    }
        //}



        /// <summary>
        /// Информация о текущем уровен доступа к данным клиентов в приложении
        /// </summary>
        //public string AccessLevelInformation
        //{
        //    get
        //    {
        //        if (UserAccessLevel == AccessLevel.Сonsultant) return "Уровень доступа - Консультант";
        //        else return "Уровень доступа - Менеджер";
        //    }
        //}

        /// <summary>
        /// Доступ к методу изменения уровня доступа в приложении через команды
        /// </summary>
        public ICommand SetAccessLevel
        {
            get => _setAccessLevel;
        }

        /// <summary>
        /// Выбранные в интерфейсе приложения клиент
        /// </summary>
        public IClient SelectedClient
        {
            get { return selectedClient; }
            set { selectedClient = value; OnPropertyChanged(); }
        }

        public ObservableCollection<ClientViewModel> Clients { get; set; }

        #endregion

        #region Methods

        public MainViewModel(ClientManager clientManager)
        {
            _appUser = new Consultant();

            _setAccessLevel = new RelayCommand(ChangeAccessLevel);

            //_clientManager = clientManager;                        

            Clients = new ObservableCollection<ClientViewModel>();

            SetClientsCollection(clientManager);

        }

        

        private void SetClientsCollection(ClientManager clientManager)
        {
            for(int i = 0; i < clientManager.Clients.Count; i++)
            {
                Clients.Add(clientManager.Clients[i]);
            }
        }


        /// <summary>
        /// Метод изменения уровня доступа в приложении
        /// </summary>
        /// <param name="parameter"></param>
        public void ChangeAccessLevel(object parameter)
        {
            var accessLevel = parameter as string;
            switch (accessLevel)
            {
                case "Консультант":
                    if(AppUser is Consultant) return;
                    else AppUser = new Consultant();
                    break;
                case "Менеджер":
                default:
                    if (AppUser is Manager) return;
                    else AppUser = new Manager();
                    break;

            }
        }

        #endregion










    }
}
