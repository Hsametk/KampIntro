// See https://aka.ms/new-console-template for more information

using ClassMethotDemo;

    Client client1 = new Client();
    client1.Name = "samet";
    client1.LastName = "kotu";

    Client client2 = new Client();
    client2.Name = "halil";
    client2.LastName = "kotu";

    ClientManager clientManager = new ClientManager();
    clientManager.Add(client1);
    clientManager.Add(client2);
    clientManager.Delete(client1);
    clientManager.Delete(client2);

    Client[] clients = new Client[] { client1,client2};
    clientManager.List(clients);