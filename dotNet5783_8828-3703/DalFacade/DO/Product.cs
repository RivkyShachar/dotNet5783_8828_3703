using System.ComponentModel;

namespace DO;
// To check Capitals 
public struct Product
{/// <summary>
/// Structure for Products, contains Id, Name, Price, Category, InStock + ToString override
/// </summary>
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Categories Category { get; set; }
    public int InStock { get; set; }
    public override string ToString() => $@"
Product ID={ID}: {Name} 
category : {Category}
Price: {Price}
Amount in stock: {InStock}
";

}
