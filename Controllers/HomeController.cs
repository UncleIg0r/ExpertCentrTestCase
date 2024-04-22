using ExpertCentrTestCase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpertCentrTestCase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;

        public HomeController( ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PriceList> priceList = _context.PriceLists.ToList();
            return View(priceList);
        }
        
        public IActionResult CreatePriceList()
        {
            return View(new PriceList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
