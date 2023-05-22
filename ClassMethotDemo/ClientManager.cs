using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    internal class ClientManager
    {

        public void Add(Client client)
        {
            Console.WriteLine("Eklendi"+client.Name);
        }
        public void Delete(Client client)
        {
            Console.WriteLine("Silindi" + client.Name);
        }

        public void List(Client[] clients)
        {
            foreach (Client client in clients)
            {
                Console.WriteLine(client.Name+" "+client.LastName);
            }
        }
    }
}
