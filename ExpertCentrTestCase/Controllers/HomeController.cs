using ExpertCentrTestCase.Core.Models;
using ExpertCentrTestCase.DataAccess;
using ExpertCentrTestCase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpertCentrTestCase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<PriceList> priceList = new();
            return View(priceList);
        }
        
        public IActionResult CreatePriceListPage()
        {
            return View();//new PriceListEntity()
        }
        /*[HttpGet]
        public IActionResult<>*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
