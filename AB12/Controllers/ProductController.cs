using AB12.Application.Products.Commands;
using AB12.Services.Components;
using Microsoft.AspNetCore.Mvc;

namespace AB12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductService _service;

        public ProductController(ILogger<ProductController> logger, ProductService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet()]
        public async Task<IActionResult> GetList()
        {
            try
            {
                var result = await _service.GetListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error getting list of products");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var result = await _service.GetByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error getting product by id");
                throw ex;
            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromForm] CreateProductCommand command)
        {
            try
            {
                var result = await _service.CreateAsync(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error creating product");
                throw ex;
            }
        }
    }
}