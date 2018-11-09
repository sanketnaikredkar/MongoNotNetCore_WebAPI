using System.Collections.Generic;
using Mongo_WebAPI.Models;

namespace DALayer.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAllProducts();
        ProductModel GetProductById(int productId);
    }
}
