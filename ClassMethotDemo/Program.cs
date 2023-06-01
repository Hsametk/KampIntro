// See https://aka.ms/new-console-template for more information

using ClassMethotDemo;

    Client client1 = new Client();
    client1.Name = "samet";
    client1.LastName = "kotu";  
    client1.Id = 1;
    client1.Value = 1000;

    Client client2 = new Client();
    client2.Name = "halil";
    client2.LastName = "kotu";
    client2.Id = 2;
    client2.Value = 1000;

    ClientManager clientManager = new ClientManager();
    clientManager.Add(client1);
    clientManager.Add(client2);
    clientManager.Remove(client1);
    clientManager.Remove(client2);

    Client[] clients = new Client[] { client1, client2 };

    clientManager.List(clients);
