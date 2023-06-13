// See https://aka.ms/new-console-template for more information
using Oop2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Samet";
customer1.LastName = "Kotu";
customer1.TcNumber = "12345678977"; 

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.CompanyName = "kodlama.io";
customer2.TaxNumber = "1234567890";

Customer customer3 = new Customer();
Customer customer4 = new Customer();
CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer4);
customerManager.Add(customer3);
customerManager.Add(customer2);