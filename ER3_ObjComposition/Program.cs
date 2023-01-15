using ER3_ObjComposition.Entities;
using ER3_ObjComposition.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth data (DD/MM/YYY): ");
string birthDate = Console.ReadLine();
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
string status = Console.ReadLine();
Console.Write("How many items to this order? ");
int nItems = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now,Enum.Parse<OrderStatus>(status), new Client(name, email, DateTime.Parse(birthDate)));

for(int i = 0; i < nItems; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data:");
    Console.Write("Product Name: ");
    string productName = Console.ReadLine();
    Console.Write("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product p = new Product(productName, productPrice);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    OrderItem item = new OrderItem(quantity, productPrice, p);
    order.AddItem(item);

}

Console.WriteLine(order);





