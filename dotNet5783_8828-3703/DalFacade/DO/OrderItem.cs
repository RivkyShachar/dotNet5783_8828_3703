namespace DO;
/// <summary>
/// Structure for Order Item, contains id, Product Id, Order Id, Price, Amount + ToString override
/// </summary>
/// 
public struct OrderItem
{
    public int? ID { get; set; }
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public double?  Price { get; set; }
    public int Amount { get; set; }
    public override string ToString() => $"Product item ID= {ID} \nProduct ID= {ProductID}" +
        $" \nOrder ID = {OrderID} \nPrice - {Price} \nAmount - {Amount}";
}
