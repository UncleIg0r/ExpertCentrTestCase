using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ExpertCentrTestCase.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomValueController : Controller
{
    private readonly ICustomValueRepository _customValueRepository;
    private readonly IColumnRepository _columnRepository;

    public CustomValueController(ICustomValueRepository customValueRepository,
        IColumnRepository columnRepository)
    {
        _customValueRepository = customValueRepository;
        _columnRepository = columnRepository;
    }
    [HttpGet]
    [Route("GetAll")]
    public async Task<List<CustomValue>> GetAll(int id)
    {
        return await _customValueRepository.GetAllByProduct(id);
    }
    [HttpGet]
    [Route("Get")]
    public async Task<CustomValue?> Get(int id)
    {
        return await _customValueRepository.GetOne(id);
    }
    [HttpPost]
    [Route("Create")]
    public async Task<List<int>> Create(List<CustomValue> customValue)
    {
        return await _customValueRepository.Create(customValue);
    }
    [HttpDelete]
    [Route("Delete")]
    public async Task<List<int>> Delete(int id)
    {
        return await _customValueRepository.DeleteAllByProduct(id);
    }
}
