namespace DO;

/// <summary>
/// Structure for Order, contains  Id, Customer Name & Email & adress, order date, shipping date, delivery date
/// + ToString override
/// </summary>
public struct Order
{
    public int? ID { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    public string? CustomerAdress { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime ShipDate { get; set; }
    public DateTime DeliveryDate { get; set; }

    public override string ToString() => $"Product ID={ID} \nCustomer Name : {CustomerName}" +
        $" \nCustomer Email : {CustomerEmail} \nCustomer Adress : {CustomerAdress}" +
        $" \nDate of order : {OrderDate} \nDate of Shipping : {ShipDate} \nDelivery Date : {DeliveryDate}";
}
