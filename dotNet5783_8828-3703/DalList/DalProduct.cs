using DO;

namespace Dal;

public class DalProduct
{
    #region Product Function
    public int AddProduct(Product product)
    {
        product.ID = DataSource.Config.getProductId;
        //Product prod = GetProduct(product.ID);
        //if (!prod.Equals(null))
        //    throw new Exception("Product with the same id already exists...");
        DataSource.productsList.Add(product);
        return product.ID;
    }
    public bool DeleteProduct(int id)
    {
        Product prod = GetProduct(id);
        if (prod.Equals(null))
            throw new Exception("Product with the same id not found...");

        DataSource.orderItemsList.RemoveAll(sc => sc.ProductID == id);

        return DataSource.productsList.Remove(prod);
    }
    public void UpdateProduct(Product product)
    {
        int index = DataSource.productsList.FindIndex(s => s.ID == product.ID);
        if (index == -1)
            throw new Exception("Product with the same id not found...");

        DataSource.productsList[index] = product;
    }
    public Product GetProduct(int id)
    {
        return DataSource.productsList.FirstOrDefault(s => s.ID == id);
    }
    public IEnumerable<Product> GetAllProducts(Func<Product, bool> predicat = null)
    {
        if (predicat == null)
            return DataSource.productsList.AsEnumerable();

        return DataSource.productsList.Where(predicat);
    }
    #endregion
}
