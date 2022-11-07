using System.ComponentModel;

namespace DO;
/// <summary>
/// Structure for Products, contains Id, Name, Price, Category, InStock + ToString override
/// </summary>
public struct Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Categories Category { get; set; }
    public int InStock { get; set; }
    public override string ToString() => $"Product ID={ID}: {Name} \ncategory : {Category} " +
        $"\nPrice: {Price} \nAmount in stock: {InStock}";

}
