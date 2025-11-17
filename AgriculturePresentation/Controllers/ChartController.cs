using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
            {
                productName="Buğday",
                productValue=320

            });
            productClasses.Add(new ProductClass
            {
                productName = "Arpa",
                productValue = 220

            });
            productClasses.Add(new ProductClass
            {
                productName = "Buğday",
                productValue = 160

            });
            productClasses.Add(new ProductClass
            {
                productName = "Buğday",
                productValue = 520

            });
            productClasses.Add(new ProductClass
            {
                productName = "Domates",
                productValue = 450

            });
            return Json(new { jsonlist = productClasses });
        }
    }
}
