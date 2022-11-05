// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void ProductOption()
{
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
Item:: enter 2
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

