using RepositoryPatternWithDapper.Models;
using System.Collections.Generic;

namespace RepositoryPatternWithDapper.Repository
{
    public interface IProductRepository
    {
        /// <summary>
        /// retrieve all products with all of its data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetProducts();
        /// <summary>
        /// Inserting a new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool InsertProduct(Product product);
        /// <summary>
        /// using the Product Id in product passed to retreive the product and update the values.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool UpdateProduct(Product product);
        /// <summary>
        /// retrieving the product using product id then delete it
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        bool DeleteProduct(string productId);
    }
}
