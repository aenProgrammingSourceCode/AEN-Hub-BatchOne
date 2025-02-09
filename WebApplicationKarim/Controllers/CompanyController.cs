using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationKarim.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        public IActionResult GetAllProducts()
        {
            var products = new List<string> { "Product1", "Product2", "Product3" };
            return Ok(products); // Returns a 200 OK with the list of products
        }

        // GET: api/products/{id}
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid product ID."); // Returns a 400 Bad Request
            }

            var product = $"Product-{id}";
            return Ok(product); // Returns a 200 OK with the product details
        }


        [Route("create")]
        [HttpPost("Create")]
        public IActionResult CreateProductForInternaltionalCustomer([FromQuery] ProductModel productModel)
        {
            if (string.IsNullOrEmpty(productModel.Name))
            {
                return BadRequest("Product name cannot be empty.");
            }

            return CreatedAtAction(nameof(GetProductById), new { id = 1 }, productModel.Name);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public IActionResult editProduct(int id, [FromQuery] ProductModel updateModel)
        {
            if (id <= 0 || string.IsNullOrEmpty(updateModel.Name))
            {
                return BadRequest("Invalid input."); // Returns a 400 Bad Request
            }

            return CreatedAtAction(nameof(GetProductById), new { id = 1 }, updateModel.Name);
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid product ID."); // Returns a 400 Bad Request
            }

            return NoContent(); // Returns a 204 No Content to indicate successful deletion
        }

    }
}
