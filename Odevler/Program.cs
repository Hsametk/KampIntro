
using Odev_1;

Product product1 = new Product();
product1.ProductName = "Macbook";
product1.ProductId = 1;
product1.Price = 20000;

Product product2 = new Product();
product2.ProductName = "Iphone";
product2.ProductId = 2;
product2.Price = 25000;

Product[] products = new Product[] { product1, product2 };

//Foreach
Console.WriteLine("Foreach");
foreach (Product product in products)
{
    Console.WriteLine(product.ProductName+" "+product.ProductId+ " "+ product.Price);
}
Console.WriteLine("For");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ProductId+ " "+ products[i].ProductName+ " "+ products[i].Price);
}
Console.WriteLine("while");
int j = 0;
while (j < products.Length)
{
    Console.WriteLine(products[j].ProductId + " " + products[j].ProductName + " " + products[j].Price);
    j++;
}