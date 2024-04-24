using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpertCentrTestCase.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    [HttpGet]
    [Route("GetAll")]
    public async Task<List<Product>> GetProducts(int id)
    {
        return await _productRepository.GetByPriceList(id);
    }
    [HttpGet]
    [Route("Get")]
    public async Task<Product?> Get(int id)
    {
        return await _productRepository.GetOne(id);
    }
    [HttpPost]
    [Route("Create")]
    public async Task<int?> Create(Product product)
    {
        return await _productRepository.Create(product);
    }
    [HttpDelete]
    [Route("Delete")]
    public async Task<int?> Delete(int id)
    {
        return await _productRepository.Delete(id);
    }
}
