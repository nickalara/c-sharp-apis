using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingWebAPIs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_context.Products.ToArray());
        }
    }
}
