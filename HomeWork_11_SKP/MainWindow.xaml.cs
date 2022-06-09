using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork_11_SKP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _mainViewModel;

        ClientManager _clientManager;
        
        public MainWindow()
        {
            _clientManager = new ClientManager();

            testAddNewClients();

            _mainViewModel = new MainViewModel(_clientManager);

            DataContext = _mainViewModel;

            InitializeComponent();
        }

        private void testAddNewClients()
        {
            _clientManager.Clients.Add(new Client() { Name = "Иван", Surname = "Иванов", Patronymic = "Иванович", PhoneNumber = "88008888888", PassportNumber = 2512749551 });
            _clientManager.Clients.Add(new Client() { Name = "Петр", Surname = "Петров", Patronymic = "Петрович", PhoneNumber = "89009999999", PassportNumber = 25069600607 });
        }
    }
}
