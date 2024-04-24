using Microsoft.AspNetCore.Mvc;
using 
    ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.DataAccess.Repositories;
using System.ComponentModel;
using ExpertCentrTestCase.Core.Models;

namespace ExpertCentrTestCase.Controllers;

[ApiController]
[Route("[controller]")]
public class PriceListController : Controller
{
    private readonly IPriceListRepository _priceListRepository;

    public PriceListController(IPriceListRepository priceListRepository)
    {
        _priceListRepository = priceListRepository;
    }
    [HttpGet]
    [Route("GetAll")]
    public async Task<List<PriceList>> GetAll()
    {
        return await _priceListRepository.GetAll();
    }
    [HttpGet]
    [Route("Get")]
    public async Task<PriceList?> Get(int id)
    {
        return await _priceListRepository.GetOne(id);
    }
    [HttpPost]
    [Route("Create")]
    public async Task<int> Create(PriceList priceList)
    {
        return await _priceListRepository.Create(priceList);
    }
    [HttpDelete]
    [Route("Delete")]
    public async Task<int?> Delete(int id)
    {
        return await _priceListRepository.Delete(id);
    }
}
