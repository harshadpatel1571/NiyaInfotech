using Microsoft.AspNetCore.Mvc;

namespace Niya_Infotech_Web.Controllers
{
    public class ServiceController : Controller
    {

        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }


        public IActionResult WebServiceDetails()
        {
            return View();
        }
        public IActionResult SoftwareServiceDetails()
        {
            return View();
        }

        public IActionResult AppServiceDetails()
        {
            return View();
        }

        public IActionResult DesignServiceDetails()
        {
            return View();
        }

        public IActionResult DigitalMarketingServiceDetails()
        {
            return View();
        }

        public IActionResult CloudNetworkingServiceDetails()
        {
            return View();
        }


    }
}
