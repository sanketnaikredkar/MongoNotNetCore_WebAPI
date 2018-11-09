using System.Collections.Generic;
using System.Linq;
using Mongo_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using IProductRepository = DALayer.Interfaces.IProductRepository;

namespace Mongo_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> Get()
        {
            var data = _repository.GetAllProducts().ToList();
            return data;
        }

        // GET api/values/1
        [HttpGet("{ProductId}")]
        public ActionResult<ProductModel> Get(int productId)
        {
            var data = _repository.GetProductById(productId);
            return data;
        }

    }
}
