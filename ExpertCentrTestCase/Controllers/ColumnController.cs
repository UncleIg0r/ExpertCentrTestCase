using ExpertCentrTestCase.Core.Interfaces;
using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ExpertCentrTestCase.Controllers;

[ApiController]
[Route("[controller]")]
public class ColumnController : Controller
{
    private readonly IColumnRepository _columnRepository;

    public ColumnController(IColumnRepository columnRepository)
    {
        _columnRepository = columnRepository;
    }
    [HttpGet]
    [Route("Get")]
    public async Task<Column?> Get(int id)
    {
        return await _columnRepository.Get(id);
    }
    [HttpPost]
    [Route("Create")]
    public async Task<int?> Create(Column column)
    {
        return await _columnRepository.Create(column);
    }
}
