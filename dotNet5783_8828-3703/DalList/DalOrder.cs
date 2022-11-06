using DO;

namespace Dal;

public class DalOrder
{
    #region Order Function
    public int AddOrder(Order order)
    {
        Order ord = GetOrder(order.ID);
        if (!ord.Equals(null))
            throw new Exception("Order with the same id already exists...");
        DataSource.ordersList.Add(order);
        return order.ID;
    }
    public bool DeleteOrder(int id)
    {
        Order ord = GetOrder(id);
        if (ord.Equals(null))
            throw new Exception("Order with the same id not found...");
        DataSource.orderItemsList.RemoveAll(sc => sc.OrderID == id);
        return DataSource.ordersList.Remove(ord);
    }
    public void UpdateOrder(Order order)
    {
        int index = DataSource.ordersList.FindIndex(s => s.ID == order.ID);
        if (index == -1)
            throw new Exception("Order with the same id not found...");
        DataSource.ordersList[index] = order;
    }
    public Order GetOrder(int id)
    {
        return DataSource.ordersList.FirstOrDefault(s => s.ID == id);
    }
    public IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.ordersList.AsEnumerable();

        return DataSource.ordersList.Where(predicat);
    }
    #endregion
}
