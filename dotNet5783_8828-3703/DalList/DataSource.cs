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
            ID = 100000,
            CustomerName = "Reuven",
            CustomerEmail = "Reuven@gmail.com",
            CustomerAdress = "Chita 1 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100001,
            CustomerName = "Shimon",
            CustomerEmail = "Shimon@gmail.com",
            CustomerAdress = "Seora 2 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100002,
            CustomerName = "Levi",
            CustomerEmail = "Levi@gmail.com",
            CustomerAdress = "Gefen 3 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100003,
            CustomerName = "Yehuda",
            CustomerEmail = "Yehuda@gmail.com",
            CustomerAdress = "Teena 4 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100004,
            CustomerName = "Zvulun",
            CustomerEmail = "Zvulun@gmail.com",
            CustomerAdress = "Rimon 5 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100005,
            CustomerName = "Ysaschar",
            CustomerEmail = "Ysaschar@gmail.com",
            CustomerAdress = "Zait 6 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100006,
            CustomerName = "Gad",
            CustomerEmail = "Gad@gmail.com",
            CustomerAdress = "Tamar 7 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100007,
            CustomerName = "Naftali",
            CustomerEmail = "Naftali@gmail.com",
            CustomerAdress = "Brosh 8 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100008,
            CustomerName = "Asher",
            CustomerEmail = "Asher@gmail.com",
            CustomerAdress = "Ela 9 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100009,
            CustomerName = "Dan",
            CustomerEmail = "Dan@gmail.com",
            CustomerAdress = "Alon 10 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100010,
            CustomerName = "Yossef",
            CustomerEmail = "Yossef@gmail.com",
            CustomerAdress = "Oren 11 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100011,
            CustomerName = "Binyamin",
            CustomerEmail = "Binyamin@gmail.com",
            CustomerAdress = "Ipea 12 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100012,
            CustomerName = "Sara",
            CustomerEmail = "Sara@gmail.com",
            CustomerAdress = "Tishrey 13 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100013,
            CustomerName = "Rivka",
            CustomerEmail = "Rivka@gmail.com",
            CustomerAdress = "Cheshvan 14 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100014,
            CustomerName = "Rachel",
            CustomerEmail = "Rachel@gmail.com",
            CustomerAdress = "Kislev 15 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100015,
            CustomerName = "Lea",
            CustomerEmail = "Lea@gmail.com",
            CustomerAdress = "Tevet 16 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100016,
            CustomerName = "Yehudit",
            CustomerEmail = "Yehudit@gmail.com",
            CustomerAdress = "Shvat 17 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100017,
            CustomerName = "Avigail",
            CustomerEmail = "Avigail@gmail.com",
            CustomerAdress = "Adar 18 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100018,
            CustomerName = "Shira",
            CustomerEmail = "Shira@gmail.com",
            CustomerAdress = "Nisan 19 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100019,
            CustomerName = "Hadas",
            CustomerEmail = "Hadas@gmail.com",
            CustomerAdress = "Tamuz 20 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            ID = 100020,
            CustomerName = "Neomi",
            CustomerEmail = "Neomi@gmail.com",
            CustomerAdress = "Av 21 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        return orders;
    }
    private static List<OrderItem> AddOrderItem()
    {
        orderItems.Add(new OrderItem { OrderID = 100000, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100000, ProductID = 100001, Price = 5, Amount = 2});
        orderItems.Add(new OrderItem { OrderID = 100001, ProductID = 100002, Price = 100, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100002, ProductID = 100003, Price = 30, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100002, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100002, ProductID = 100006, Price = 78, Amount = 2});
        orderItems.Add(new OrderItem { OrderID = 100002, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100003, ProductID = 100005, Price = 80, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100004, ProductID = 100001, Price = 5, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100004, ProductID = 100002, Price = 100, Amount = 5});
        orderItems.Add(new OrderItem { OrderID = 100004, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100005, ProductID = 100004, Price = 20, Amount = 2});
        orderItems.Add(new OrderItem { OrderID = 100005, ProductID = 100003, Price = 30, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100006, ProductID = 100007, Price = 3, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100006, ProductID = 100006, Price = 78, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100006, ProductID = 100009, Price = 25, Amount = 2});
        orderItems.Add(new OrderItem { OrderID = 100006, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100007, ProductID = 100001, Price = 5, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100007, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100007, ProductID = 100010, Price = 55, Amount = 3});
        orderItems.Add(new OrderItem { OrderID = 100007, ProductID = 100004, Price = 20, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100008, ProductID = 100003, Price = 30, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100008, ProductID = 100005, Price = 80, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100008, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100009, ProductID = 100001, Price = 5, Amount = 8});
        orderItems.Add(new OrderItem { OrderID = 100009, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100010, ProductID = 100009, Price = 25, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100011, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100011, ProductID = 100006, Price = 78, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100012, ProductID = 100003, Price = 30, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100013, ProductID = 100001, Price = 5, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100014, ProductID = 100007, Price = 3, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100014, ProductID = 100000, Price = 10, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100015, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100016, ProductID = 100009, Price = 25, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100017, ProductID = 100010, Price = 55, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100017, ProductID = 100008, Price = 13, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100017, ProductID = 100007, Price = 3, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100018, ProductID = 100001, Price = 5, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100018, ProductID = 100006, Price = 78, Amount = 1});
        orderItems.Add(new OrderItem { OrderID = 100019, ProductID = 100005, Price = 80, Amount = 2});
        orderItems.Add(new OrderItem { OrderID = 100019, ProductID = 100004, Price = 20, Amount = 3});
        return orderItems;
    }
    private static List<Product> AddProduct()
    {
        products.Add(new Product
        {
            ID=100000,
            Name="Aeroplane",
            Price=10,
            Category=Categories.CRAFTS,
            InStock=19,
        });
        products.Add(new Product
        {
            ID = 100001,
            Name = "Ball",
            Price =5,
            Category =Categories.OUTDOOR,
            InStock =30,
        });
        products.Add(new Product
        {
            ID = 100002,
            Name = "Bicycle",
            Price =100,
            Category =Categories.RIDING_TOYS,
            InStock =1,
        });
        products.Add(new Product
        {
            ID = 100003,
            Name = "Car",
            Price =30,
            Category =Categories.CARS_AND_RIDING_TOYS,
            InStock =0,
        });
        products.Add(new Product
        {
            ID = 100004,
            Name = "Teddybear",
            Price =20,
            Category =Categories.DOLLS,
            InStock =4,
        });
        products.Add(new Product
        {
            ID = 100005,
            Name = "Rocking horse",
            Price =80,
            Category =Categories.WOODEN,
            InStock =0,
        });
        products.Add(new Product
        {
            ID = 100006,
            Name = "Doll",
            Price =78,
            Category =Categories.DOLLS,
            InStock =7,
        });
        products.Add(new Product
        {
            ID = 100007,
            Name = "Duck",
            Price =3,
            Category =Categories.BATH_TOYS,
            InStock =25,
        });
        products.Add(new Product
        {
            ID = 100008,
            Name = "Kite",
            Price =13,
            Category =Categories.OUTDOOR,
            InStock =6,
        });
        products.Add(new Product
        {
            ID = 100009,
            Name = "Puzzle",
            Price = 25,
            Category =Categories.PUZZLES,
            InStock =8,
        });
        products.Add(new Product
        {
            ID = 100010,
            Name = "Bimba",
            Price = 55,
            Category =Categories.RIDING_TOYS,
            InStock =0,
        });
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
