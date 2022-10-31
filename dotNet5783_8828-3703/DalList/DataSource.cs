using DO;

namespace Dal;

internal static class DataSource
{
    //need to fix capital letters and such

    //need to check in its really public
    //need to check if this is the right way to write this part(random)
    public static Random? random = new Random();
    public static int? randNum = random.Next(1,20);

    internal static List<Order>? orders;
    internal static List<OrderItem>? orderItems;
    internal static List<Product>? products;

    //static DataSource()
    //{
    //    s_Initialize()
    //}
    private static List<Order> AddOrder()
    {
        orders.Add(new Order());
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
    //private void static s_Initialize()
    //{
    //    AddProduct();
    //    AddOrder();
    //    AddOrderItem();
    //}
}
