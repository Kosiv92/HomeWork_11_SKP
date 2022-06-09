using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_SKP
{
    internal class ClientManager
    {
        private List<IClient> _clients;

        public List<IClient> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public ClientManager()
        {
            _clients = new List<IClient>();
        }
    }
}
