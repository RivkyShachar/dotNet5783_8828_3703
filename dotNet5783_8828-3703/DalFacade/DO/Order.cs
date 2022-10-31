namespace DO;

public struct Order
{/// <summary>
/// Structure for Order, contains  Id, Customer Name & Email & adress, order date, shipping date, delivery date
/// + ToString override
/// </summary>
    public int ID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAdress { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime ShipDate { get; set; }
    public DateTime DeliveryDate { get; set; }

    public override string ToString() => $@"
      Product ID={ID} 
      Customer Name : {CustomerName}
      Customer Email : {CustomerEmail}
      Customer Adress : {CustomerAdress}
      Date of order : {OrderDate}
      Date of Shipping : {ShipDate}
      Delivery Date : {DeliveryDate}
";

}
