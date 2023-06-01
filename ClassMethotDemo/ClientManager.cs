using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    internal class ClientManager
    {

        public void Add(Client client) 
        {
            Console.WriteLine(client.Id+ " "+client.Value+" "+ "eklendi.");
        }
        public void Remove(Client client)
        {
            Console.WriteLine(client.Name + " "+ client.Age+"silindi");
        }

        public void List(Client[] clients)
        {
            foreach (Client client in clients)
            {
                Console.WriteLine(client.Name+ " "+ client.Id+" Listelendi");
            }
        }
    }
}
