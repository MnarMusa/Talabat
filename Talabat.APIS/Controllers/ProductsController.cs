using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contract;

namespace Talabat.APIS.Controllers
{
   
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepository<Product> _productRepo;

        public ProductsController(IGenericRepository<Product >productRepo)
        {
            _productRepo = productRepo;
        }


        [HttpGet]
        public async Task <ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productRepo.GetAllAsync();
            return Ok(products);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(int id)
        {
            var products = await _productRepo.GetAllAsync();
            if (products == null)
            {
                return NotFound(new { Massage = "not found",StatusCode=404 });
            }
           
            return Ok(products);
        }

    }
}
