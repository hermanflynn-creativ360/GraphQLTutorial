using GraphQLTutorial.Interfaces;
using GraphQLTutorial.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraphQLTutorial.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProject _productService;

        public ProductsController(IProject productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductByID(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            _productService.AddProject(product);
            return product;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product product)
        {
            _productService.UpdateProject(id, product);
            return product;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProject(id);
        }
    }
}
