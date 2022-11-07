using DO;

namespace Dal;

public class DalOrderItem
{
    #region OrderItem Function
    public int? Add(OrderItem orderItem)
    {
        orderItem.ID = DataSource.Config.GetOrderItemId;
        if (DataSource.orderItemsList.Contains(orderItem))
            throw new Exception("This order item is already exist...");
        DataSource.orderItemsList.Add(orderItem);
        return orderItem.ID;
    }
    public void Delete(int id)
    {
        OrderItem orderItem = Get(id);
        if (orderItem.Equals(null))
            throw new Exception("Order item with the same id not found...");
        DataSource.orderItemsList.Remove(orderItem);
    }
    public void Update(OrderItem orderItem)
    {
        int index = DataSource.orderItemsList.FindIndex(s => s.ID == orderItem.ID);
        if (index == -1)
            throw new Exception("Order item with the same id not found...");
        DataSource.orderItemsList[index] = orderItem;
    }
    public OrderItem Get(int id) => DataSource.orderItemsList.FirstOrDefault(s => s.ID == id);
    public IEnumerable<OrderItem> GetAll(Func<OrderItem, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.orderItemsList.AsEnumerable();

        return DataSource.orderItemsList.Where(predicat);
    }
    #endregion
}
