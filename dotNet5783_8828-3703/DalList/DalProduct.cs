using DO;
using DalApi;

namespace Dal;
/// <summary>
/// DalProduct contain add, update, delete, get and get all methods on product
/// </summary>
internal class DalProduct : IProduct
{
    #region Product Function
    public int? Add(Product product)
    {
        product.ID = DataSource.Config.getProductId;
        if(DataSource.productsList.Contains(product))
            throw new Exception("This product is already exist...");
        DataSource.productsList.Add(product);
        return product.ID;
    }
    public void Delete(int id)
    {
        Product product = Get(id);
        if (product.Equals(null))
            throw new Exception("Product with the same id not found...");
        DataSource.productsList.Remove(product);
    }
    public void Update(Product product)
    {
        int index = DataSource.productsList.FindIndex(s => s.ID == product.ID);
        if (index == -1)
            throw new Exception("Product with the same id not found...");

        DataSource.productsList[index] = product;
    }
    public Product Get(int? id)=>DataSource.productsList.FirstOrDefault(s => s.ID == id);
    public IEnumerable<Product> GetAll(Func<Product, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.productsList.AsEnumerable();

        return DataSource.productsList.Where(predicat);
    }
    #endregion
}
