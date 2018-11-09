using System.Collections.Generic;
using DALayer.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Mongo_WebAPI.Models;
using Mongo_WebAPI.MongoRepository;

namespace DALayer.MongoRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MongoDatabase _db;
        public ProductRepository()
        {
            var server = DbConnection.ConnectServer();
            _db = server.GetDatabase("ProductsDB");
        }
        public IEnumerable<ProductModel> GetAllProducts()
        {
            var productData = _db.GetCollection<ProductModel>("Products").FindAll();
            return productData;
        }

        public ProductModel GetProductById(int productId)
        {
            var res = Query<ProductModel>.EQ(p => p.ProductId, productId);
            var productData = _db.GetCollection<ProductModel>("Products").FindOne(res);
            return productData;
        }
    }
}
