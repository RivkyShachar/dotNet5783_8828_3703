using DO;
using DalApi;

namespace Dal;

internal class DalOrder : IOrder
{
    #region Order Function

    public int? Add(Order order)
    {
        order.ID = DataSource.Config.getOrderId;
        if (DataSource.ordersList.Contains(order))
            throw new Exception("This order is already exist...");
        DataSource.ordersList.Add(order);
        return order.ID;
    }
    public void Delete(int id)
    {
        Order order = Get(id);
        if (order.Equals(null))
            throw new Exception("Order with the same id not found...");
        DataSource.ordersList.Remove(order);
    }
    public void Update(Order order)
    {
        int index = DataSource.ordersList.FindIndex(s => s.ID == order.ID);
        if (index == -1)
            throw new Exception("Order with the same id not found...");
        DataSource.ordersList[index] = order;
    }
    public Order Get(int? id)=>DataSource.ordersList.FirstOrDefault(s => s.ID == id);
    public IEnumerable<Order> GetAll(Func<Order, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.ordersList.AsEnumerable();

        return DataSource.ordersList.Where(predicat);
    }
    #endregion
}
