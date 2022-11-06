// See https://aka.ms/new-console-template for more information
using Dal;
using DO;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
void ProductOption()
{
    DalProduct dalProduct = new DalProduct();
    Console.WriteLine(@"Product options
Add a product: enter a
Get a profuct: enter b
Get all products: enter c
Update a product: enter d
Delete a product: enter e");
    string option=Console.ReadLine();
    switch (option)
    {
        case "a":
            Console.WriteLine("for adding a product please enter the folowing");
            break;
        case "b":
            Console.WriteLine("Enter the product id you want to get");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dalProduct.GetProduct(productId).ToString());
            break;
        case "c":
            IEnumerable<Product> products = new List<Product>();
            products=dalProduct.GetAllProducts();
            foreach(Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
            break;
        case "d":
            Console.WriteLine("for updating a product please enter the folowing");
            break;
        case "e":
            Console.WriteLine("Enter the product id you want to delete");
            productId = Convert.ToInt32(Console.ReadLine());
            dalProduct.DeleteProduct(productId);
            break;
        default:
            break;
    }

}
void OrderOption()
{

}
void OrderItemOption()
{

}
void PrintOptions()
{
    Console.WriteLine(@"Please choose one of the folowing:
EXIT: enter 0
Product: enter 1
Item: enter 2
Order-item: enter 3");
}
string choose;
do
{
    PrintOptions();
    choose = Console.ReadLine();
    switch (choose)
    {
        case "0":
            Console.WriteLine("Bye");
            break;
        case "1":
            ProductOption();
            break;
        case "2":
            OrderOption();
            break;
        case "3":
            OrderItemOption();
            break;
        default:
            Console.WriteLine("The option {0} doesn't exist",choose);
            break;
    }
}
while (choose != "0");

