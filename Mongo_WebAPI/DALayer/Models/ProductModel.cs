using MongoDB.Bson;

namespace Mongo_WebAPI.Models
{
    public class ProductModel
    {
        public ObjectId Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}
