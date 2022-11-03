using System.ComponentModel;
using DO;

namespace Dal;

internal static class DataSource
{
   
    //need to fix capital letters and such

    //need to check in its really public
    //need to check if this is the right way to write this part(random)
    //public static Random random = new Random();// The next randoms will be Id=random.Next(100100,999999)

    internal static List<Order> orders = new List<Order>();
    internal static List<OrderItem>? orderItems;
    internal static List<Product>? products;

    static DataSource()
    {
        s_Initialize();
    }
    // IF NEEDED FUNCT TO GENERATE DIFFERENT RANDOM INT :
    //private static void Shuffle(int []arr)
    //{//when a random id is called, do : var numbers = Enumerable.Range(100100,999999).ToArray();
    // // Shuffle(numbers);
    // //ID = numbers[0];
    //    Random rnd = new Random();
    //    for (int i = arr.Length; i > 1; i--)
    //    {
    //        int pos = rnd.Next(i);
    //        var x = arr[i - 1];
    //        arr[i - 1] = arr[pos];
    //        arr[pos] = x;
    //    }
    //}
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
        orders.Add(new Order
        {
            CustomerName = "Sara",
            CustomerEmail = "Sara@gmail.com",
            CustomerAdress = "Tishrey 13 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Rivka",
            CustomerEmail = "Rivka@gmail.com",
            CustomerAdress = "Cheshvan 14 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Rachel",
            CustomerEmail = "Rachel@gmail.com",
            CustomerAdress = "Kislev 15 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Lea",
            CustomerEmail = "Lea@gmail.com",
            CustomerAdress = "Tevet 16 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Yehudit",
            CustomerEmail = "Yehudit@gmail.com",
            CustomerAdress = "Shvat 17 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Avigail",
            CustomerEmail = "Avigail@gmail.com",
            CustomerAdress = "Adar 18 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Shira",
            CustomerEmail = "Shira@gmail.com",
            CustomerAdress = "Nisan 19 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
            CustomerName = "Hadas",
            CustomerEmail = "Hadas@gmail.com",
            CustomerAdress = "Tamuz 20 Haifa",
            OrderDate = order.OrderDate,
            ShipDate = order.ShipDate,
            DeliveryDate = order.DeliveryDate
        });
        orders.Add(new Order
        {
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
        orderItems.Add(new OrderItem());
        return orderItems;
    }
    private static List<Product> AddProduct()
    {

        products.Add(new Product
    {
      
        //Name =,
        //Price=,
        //Category=,
        //InStock=,

    }) ;
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
