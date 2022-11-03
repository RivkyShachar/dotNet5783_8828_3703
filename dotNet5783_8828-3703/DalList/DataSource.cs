using DO;

namespace Dal;

internal static class DataSource
{
    //need to fix capital letters and such

    //need to check in its really public
    //need to check if this is the right way to write this part(random)
    public static Random? random = new Random();
    public static int? randNum = random.Next(1,20);

    internal static List<Order> orders = new List<Order>();
    internal static List<OrderItem>? orderItems;
    internal static List<Product>? products;

    static DataSource()
    {
        s_Initialize();
    }
    private static List<Order> AddOrder()
    {
        //ship is 5 days from order
        TimeSpan OrderToShip = new(5, 0, 0, 0);
        //delivery is 4 days from ship
        TimeSpan ShipToDelivery = new(4, 0, 0, 0);
        Order order = new Order();
        order.OrderDate = DateTime.MinValue;
        order.ShipDate = order.OrderDate.Add(OrderToShip);
        order.DeliveryDate = order.ShipDate.Add(ShipToDelivery);
        orders.Add(new Order
        {
            CustomerName = "Reuven",
            CustomerEmail = "Reuven@gmail.com",
            CustomerAdress = "Chita 1 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Shimon",
            CustomerEmail = "Shimon@gmail.com",
            CustomerAdress = "Seora 2 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Levi",
            CustomerEmail = "Levi@gmail.com",
            CustomerAdress = "Gefen 3 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Yehuda",
            CustomerEmail = "Yehuda@gmail.com",
            CustomerAdress = "Teena 4 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Zvulun",
            CustomerEmail = "Zvulun@gmail.com",
            CustomerAdress = "Rimon 5 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Ysaschar",
            CustomerEmail = "Ysaschar@gmail.com",
            CustomerAdress = "Zait 6 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Gad",
            CustomerEmail = "Gad@gmail.com",
            CustomerAdress = "Tamar 7 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Naftali",
            CustomerEmail = "Naftali@gmail.com",
            CustomerAdress = "Brosh 8 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Asher",
            CustomerEmail = "Asher@gmail.com",
            CustomerAdress = "Ela 9 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Dan",
            CustomerEmail = "Dan@gmail.com",
            CustomerAdress = "Alon 10 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Yossef",
            CustomerEmail = "Yossef@gmail.com",
            CustomerAdress = "Oren 11 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Binyamin",
            CustomerEmail = "Binyamin@gmail.com",
            CustomerAdress = "Ipea 12 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        return orders;
    }
    private static List<OrderItem> AddOrderItem()
    {
        orderItems.Add(new OrderItem());
        return orderItems;
    }
    private static List<Product> AddProduct()
    {
        products.Add(new Product());
        return products;
    }
    private static void s_Initialize()
    {
        AddProduct();
        AddOrder();
        AddOrderItem();
    }

    internal static class Config
    {

    }
}
