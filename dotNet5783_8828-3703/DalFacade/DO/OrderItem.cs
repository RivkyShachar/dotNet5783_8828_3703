﻿namespace DO;

/// <summary>
/// Structure for Order Item, contains Product Id, Order Id, Price, Amount + ToString override
/// </summary>
public struct OrderItem
{
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
    public override string ToString() => $@"
    Product ID= {ProductID}
    Order ID = {OrderID}
    Price - {Price}
    Amount - {Amount}
   ";
}
