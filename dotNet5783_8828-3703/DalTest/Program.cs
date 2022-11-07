// See https://aka.ms/new-console-template for more information
using Dal;
using DO;
using System.Collections.Generic;

void ProductOption()
{
    DalProduct dalProduct = new DalProduct();
    
    Console.WriteLine($"Product options \nAdd a product: enter a \nGet a profuct: enter b " +
        $"\nGet all products: enter c \nUpdate a product: enter d \nDelete a product: enter e");
    try
    {
        string option = Console.ReadLine();
        switch (option)
        {
            case "a":
                Console.WriteLine("for adding a product please enter the folowing: name,price,category(0-9),how many in stock");
                Product p1 = new Product();
                p1.Name = Console.ReadLine();
                p1.Price = int.Parse(Console.ReadLine());
                p1.Category = (Categories)int.Parse(Console.ReadLine());
                p1.InStock = int.Parse(Console.ReadLine());
                Console.WriteLine($"The product id is: {dalProduct.Add(p1)}");
                break;
            case "b":
                Console.WriteLine("Enter the product id you want to get");
                int productId1 = int.Parse(Console.ReadLine());
                Console.WriteLine(dalProduct.Get(productId1));
                break;
            case "c":
                IEnumerable<Product> products = new List<Product>();
                products = dalProduct.GetAll();
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
                break;
            case "d":
                Console.WriteLine("for updating a product please enter the folowing: id name,price,category(0-9),how many in stock");
                Product p2 = new Product();
                p2.ID = int.Parse(Console.ReadLine());
                p2.Name = Console.ReadLine();
                p2.Price = int.Parse(Console.ReadLine());
                p2.Category = (Categories)int.Parse(Console.ReadLine());
                p2.InStock = int.Parse(Console.ReadLine());
                dalProduct.Update(p2);
                break;
            case "e":
                Console.WriteLine("Enter the product id you want to delete");
                int productId2 = int.Parse(Console.ReadLine());
                dalProduct.Delete(productId2);
                break;
            default:
                break;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex);
    }
}
void OrderOption()
{
    DalOrder dalOrder = new DalOrder();

        Console.WriteLine($"Order options \nAdd an order: enter a \nGet an order: enter b " +
            $"\nGet all orders: enter c \nUpdate an order: enter d \nDelete an order: enter e");
    try
    {
        //ship is 5 days from order
        TimeSpan OrderToShip = new(5, 0, 0, 0);
        //delivery is 4 days from ship
        TimeSpan ShipToDelivery = new(4, 0, 0, 0);
        string option = Console.ReadLine();
        switch (option)
        {
            case "a":
                Console.WriteLine("for adding an order please enter the folowing: name, email, address");
                Order o1 = new Order();
                o1.CustomerName = Console.ReadLine();
                o1.CustomerEmail = Console.ReadLine();
                o1.CustomerAdress = Console.ReadLine();
                o1.OrderDate = DateTime.Now;
                o1.ShipDate = o1.OrderDate.Add(OrderToShip);
                o1.DeliveryDate = o1.ShipDate.Add(ShipToDelivery);
                Console.WriteLine($"The order id is: {dalOrder.Add(o1)}");
                break;
            case "b":
                Console.WriteLine("Enter the order id you want to get");
                int orderID = int.Parse(Console.ReadLine());
                Console.WriteLine(dalOrder.Get(orderID));
                break;
            case "c":
                IEnumerable<Order> orders = new List<Order>();
                orders = dalOrder.GetAll();
                foreach (Order order in orders)
                {
                    Console.WriteLine(order);
                }
                break;
            case "d":
                Console.WriteLine("for updating an order please enter the folowing: id, name, email, address");
                Order o2 = new Order();
                o2.ID = int.Parse(Console.ReadLine());
                o2.CustomerName = Console.ReadLine();
                o2.CustomerEmail = Console.ReadLine();
                o2.CustomerAdress = Console.ReadLine();
                o2.OrderDate = DateTime.Now;
                o2.ShipDate = o2.OrderDate.Add(OrderToShip);
                o2.DeliveryDate = o2.ShipDate.Add(ShipToDelivery);
                dalOrder.Update(o2);
                break;
            case "e":
                Console.WriteLine("Enter the order id you want to delete");
                orderID = int.Parse(Console.ReadLine());
                dalOrder.Delete(orderID);
                break;
            default:
                break;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex);
    }
    }
void OrderItemOption()
{
    DalOrderItem dalOrderItem = new DalOrderItem();
    DalProduct dalProduct = new DalProduct();
    Console.WriteLine($"Order Item options \nAdd an order: enter a \nGet an order: enter b " +
        $"\nGet all orders: enter c \nUpdate an order: enter d \nDelete an order: enter e");
    try
    {
        string option = Console.ReadLine();
        switch (option)
        {
            case "a":
                Console.WriteLine("for adding an order item please enter the folowing: product id, order id, amount");
                OrderItem o1 = new OrderItem();
                Product p1 =new Product();
                o1.ProductID = int.Parse(Console.ReadLine());
                o1.OrderID = int.Parse(Console.ReadLine());
                o1.Amount = int.Parse(Console.ReadLine());
                p1=dalProduct.Get(o1.ProductID);
                o1.Price = p1.Price * o1.Amount;
                dalOrderItem.Add(o1);
                break;
            case "b":
                Console.WriteLine("Enter the order id you want to get");
                int orderItemID = int.Parse(Console.ReadLine());
                Console.WriteLine(dalOrderItem.Get(orderItemID));
                break;
            case "c":
                IEnumerable<OrderItem> orderItems = new List<OrderItem>();
                orderItems = dalOrderItem.GetAll();
                foreach (OrderItem orderItem in orderItems)
                {
                    Console.WriteLine(orderItem);
                }
                break;
            case "d":
                Console.WriteLine("for updating an order item please enter the folowing: id, product id, order id, amount");
                OrderItem o2 = new OrderItem();
                Product p2 = new Product();
                o2.ID=int.Parse(Console.ReadLine());
                o2.ProductID = int.Parse(Console.ReadLine());
                o2.OrderID = int.Parse(Console.ReadLine());
                o2.Amount = int.Parse(Console.ReadLine());
                p2 = dalProduct.Get(o2.ProductID);
                o2.Price = p2.Price * o2.Amount;
                dalOrderItem.Update(o2);
                break;
            case "e":
                Console.WriteLine("Enter the order id you want to delete");
                orderItemID = int.Parse(Console.ReadLine());
                dalOrderItem.Delete(orderItemID);
                break;
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    
}

string choose;
do
{
    Console.WriteLine("Please choose one of the folowing: \nEXIT: enter 0 " +
        "\nProduct: enter 1 \nItem: enter 2 \nOrder-item: enter 3");
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
            Console.WriteLine($"The option {choose} doesn't exist");
            break;
    }
}
while (choose != "0");

