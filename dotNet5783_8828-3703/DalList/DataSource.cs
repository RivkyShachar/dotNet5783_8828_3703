using System.Collections.Generic;
using System.ComponentModel;
using DO;

namespace Dal;

internal static class DataSource
{
    //need to check if this is the right way to write this part(random)
    //public static Random random = new Random();// The next randoms will be Id=random.Next(100100,999999)

    internal static List<Order> ordersList = new List<Order>();
    internal static List<OrderItem> orderItemsList =new List<OrderItem>();
    internal static List<Product> productsList = new List<Product>();

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
        ordersList.Add(new Order
        {
            ID = 100000,
            CustomerName = "Reuven",
            CustomerEmail = "Reuven@gmail.com",
            CustomerAdress = "Chita 1 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100001,
            CustomerName = "Shimon",
            CustomerEmail = "Shimon@gmail.com",
            CustomerAdress = "Seora 2 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100002,
            CustomerName = "Levi",
            CustomerEmail = "Levi@gmail.com",
            CustomerAdress = "Gefen 3 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100003,
            CustomerName = "Yehuda",
            CustomerEmail = "Yehuda@gmail.com",
            CustomerAdress = "Teena 4 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100004,
            CustomerName = "Zvulun",
            CustomerEmail = "Zvulun@gmail.com",
            CustomerAdress = "Rimon 5 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100005,
            CustomerName = "Ysaschar",
            CustomerEmail = "Ysaschar@gmail.com",
            CustomerAdress = "Zait 6 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100006,
            CustomerName = "Gad",
            CustomerEmail = "Gad@gmail.com",
            CustomerAdress = "Tamar 7 Tel-Aviv",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100007,
            CustomerName = "Naftali",
            CustomerEmail = "Naftali@gmail.com",
            CustomerAdress = "Brosh 8 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100008,
            CustomerName = "Asher",
            CustomerEmail = "Asher@gmail.com",
            CustomerAdress = "Ela 9 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100009,
            CustomerName = "Dan",
            CustomerEmail = "Dan@gmail.com",
            CustomerAdress = "Alon 10 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100010,
            CustomerName = "Yossef",
            CustomerEmail = "Yossef@gmail.com",
            CustomerAdress = "Oren 11 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100011,
            CustomerName = "Binyamin",
            CustomerEmail = "Binyamin@gmail.com",
            CustomerAdress = "Ipea 12 Beit-Shemesh",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100012,
            CustomerName = "Sara",
            CustomerEmail = "Sara@gmail.com",
            CustomerAdress = "Tishrey 13 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100013,
            CustomerName = "Rivka",
            CustomerEmail = "Rivka@gmail.com",
            CustomerAdress = "Cheshvan 14 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100014,
            CustomerName = "Rachel",
            CustomerEmail = "Rachel@gmail.com",
            CustomerAdress = "Kislev 15 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100015,
            CustomerName = "Lea",
            CustomerEmail = "Lea@gmail.com",
            CustomerAdress = "Tevet 16 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100016,
            CustomerName = "Yehudit",
            CustomerEmail = "Yehudit@gmail.com",
            CustomerAdress = "Shvat 17 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100017,
            CustomerName = "Avigail",
            CustomerEmail = "Avigail@gmail.com",
            CustomerAdress = "Adar 18 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100018,
            CustomerName = "Shira",
            CustomerEmail = "Shira@gmail.com",
            CustomerAdress = "Nisan 19 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100019,
            CustomerName = "Hadas",
            CustomerEmail = "Hadas@gmail.com",
            CustomerAdress = "Tamuz 20 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        ordersList.Add(new Order
        {
            ID = 100020,
            CustomerName = "Neomi",
            CustomerEmail = "Neomi@gmail.com",
            CustomerAdress = "Av 21 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        return ordersList;
    }
    private static List<OrderItem> AddOrderItem()
    {
        orderItemsList.Add(new OrderItem { ID = 100000, OrderID = 100000, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100001, OrderID = 100000, ProductID = 100001, Price = 5, Amount = 2});
        orderItemsList.Add(new OrderItem { ID = 100002, OrderID = 100001, ProductID = 100002, Price = 100, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100003, OrderID = 100002, ProductID = 100003, Price = 30, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100004, OrderID = 100002, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100005, OrderID = 100002, ProductID = 100006, Price = 78, Amount = 2});
        orderItemsList.Add(new OrderItem { ID = 100006, OrderID = 100002, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100007, OrderID = 100003, ProductID = 100005, Price = 80, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100008, OrderID = 100004, ProductID = 100001, Price = 5, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100009, OrderID = 100004, ProductID = 100002, Price = 100, Amount = 5});
        orderItemsList.Add(new OrderItem { ID = 100010, OrderID = 100004, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100011, OrderID = 100005, ProductID = 100004, Price = 20, Amount = 2});
        orderItemsList.Add(new OrderItem { ID = 100012, OrderID = 100005, ProductID = 100003, Price = 30, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100013, OrderID = 100006, ProductID = 100007, Price = 3, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100014, OrderID = 100006, ProductID = 100006, Price = 78, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100015, OrderID = 100006, ProductID = 100009, Price = 25, Amount = 2});
        orderItemsList.Add(new OrderItem { ID = 100016, OrderID = 100006, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100017, OrderID = 100007, ProductID = 100001, Price = 5, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100018, OrderID = 100007, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100019, OrderID = 100007, ProductID = 100010, Price = 55, Amount = 3});
        orderItemsList.Add(new OrderItem { ID = 100020, OrderID = 100007, ProductID = 100004, Price = 20, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100021, OrderID = 100008, ProductID = 100003, Price = 30, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100022, OrderID = 100008, ProductID = 100005, Price = 80, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100023, OrderID = 100008, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100024, OrderID = 100009, ProductID = 100001, Price = 5, Amount = 8});
        orderItemsList.Add(new OrderItem { ID = 100025, OrderID = 100009, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100026, OrderID = 100010, ProductID = 100009, Price = 25, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100027, OrderID = 100011, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100028, OrderID = 100011, ProductID = 100006, Price = 78, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100029, OrderID = 100012, ProductID = 100003, Price = 30, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100030, OrderID = 100013, ProductID = 100001, Price = 5, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100031, OrderID = 100014, ProductID = 100007, Price = 3, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100032, OrderID = 100014, ProductID = 100000, Price = 10, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100033, OrderID = 100015, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100034, OrderID = 100016, ProductID = 100009, Price = 25, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100035, OrderID = 100017, ProductID = 100010, Price = 55, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100036, OrderID = 100017, ProductID = 100008, Price = 13, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100037, OrderID = 100017, ProductID = 100007, Price = 3, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100038, OrderID = 100018, ProductID = 100001, Price = 5, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100039, OrderID = 100018, ProductID = 100006, Price = 78, Amount = 1});
        orderItemsList.Add(new OrderItem { ID = 100040, OrderID = 100019, ProductID = 100005, Price = 80, Amount = 2});
        orderItemsList.Add(new OrderItem { ID = 100041, OrderID = 100019, ProductID = 100004, Price = 20, Amount = 3});
        return orderItemsList;
    }
    private static List<Product> AddProduct()
    {
        productsList.Add(new Product
        {
            ID=100000,
            Name="Aeroplane",
            Price=10,
            Category=Categories.CRAFTS,
            InStock=19,
        });
        productsList.Add(new Product
        {
            ID = 100001,
            Name = "Ball",
            Price =5,
            Category =Categories.OUTDOOR,
            InStock =30,
        });
        productsList.Add(new Product
        {
            ID = 100002,
            Name = "Bicycle",
            Price =100,
            Category =Categories.RIDING_TOYS,
            InStock =1,
        });
        productsList.Add(new Product
        {
            ID = 100003,
            Name = "Car",
            Price =30,
            Category =Categories.CARS_AND_RIDING_TOYS,
            InStock =0,
        });
        productsList.Add(new Product
        {
            ID = 100004,
            Name = "Teddybear",
            Price =20,
            Category =Categories.DOLLS,
            InStock =4,
        });
        productsList.Add(new Product
        {
            ID = 100005,
            Name = "Rocking horse",
            Price =80,
            Category =Categories.WOODEN,
            InStock =0,
        });
        productsList.Add(new Product
        {
            ID = 100006,
            Name = "Doll",
            Price =78,
            Category =Categories.DOLLS,
            InStock =7,
        });
        productsList.Add(new Product
        {
            ID = 100007,
            Name = "Duck",
            Price =3,
            Category =Categories.BATH_TOYS,
            InStock =25,
        });
        productsList.Add(new Product
        {
            ID = 100008,
            Name = "Kite",
            Price =13,
            Category =Categories.OUTDOOR,
            InStock =6,
        });
        productsList.Add(new Product
        {
            ID = 100009,
            Name = "Puzzle",
            Price = 25,
            Category =Categories.PUZZLES,
            InStock =8,
        });
        productsList.Add(new Product
        {
            ID = 100010,
            Name = "Bimba",
            Price = 55,
            Category =Categories.RIDING_TOYS,
            InStock =0,
        });
        return productsList;
    }
    /// <summary>
    /// initialize the lists with data
    /// </summary>
    private static void s_Initialize()
    {
        productsList=AddProduct();
        ordersList=AddOrder();
        orderItemsList=AddOrderItem();
    }

    /// <summary>
    /// give an individual id for product, item and order item
    /// </summary>
    internal static class Config
    {
        /// The first next available index in the array of each :
        internal static int OrderIndex = 0;
        internal static int ProductIndex = 0;
        internal static int OrderItemIndex = 0;

        /// First available Id for automatic Id:
        private static int firstOrderId = 100100;
        private static int firstProductId = 100100;
        private static int firstOrderItemId = 100100;
        public static int getOrderId {  get { return firstOrderId++; } }
        public static int getProductId { get { return firstProductId++; } }
        public static int GetOrderItemId { get { return firstOrderItemId++; } }

    }

}
