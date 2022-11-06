using DO;

namespace Dal;

public class DalOrderItem
{
    #region OrderItem Function
    public void AddOrderItem(OrderItem orderItem)
    {
        DataSource.orderItemsList.Add(orderItem);
        //need to ask what it returns
        //return orderItem.OrderID;
    }
    public bool DeleteOrderItem(int id)
    {
        OrderItem ordItm = GetOrderItem(id);
        if (ordItm.Equals(null))
            throw new Exception("Order item with the same id not found...");
        DataSource.orderItemsList.RemoveAll(sc => sc.OrderID == id);
        return DataSource.orderItemsList.Remove(ordItm);
    }
    public void UpdateOrderItem(OrderItem orderItem)
    {
        int index = DataSource.orderItemsList.FindIndex(s => s.OrderID == orderItem.OrderID);
        if (index == -1)
            throw new Exception("Order item with the same id not found...");
        DataSource.orderItemsList[index] = orderItem;
    }
    public OrderItem GetOrderItem(int id)
    {
        //need to ask what it returns
        return DataSource.orderItemsList.FirstOrDefault(s => s.OrderID == id);
    }
    public IEnumerable<OrderItem> GetAllOrederItems(Func<OrderItem, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.orderItemsList.AsEnumerable();

        return DataSource.orderItemsList.Where(predicat);
    }
    #endregion
}
