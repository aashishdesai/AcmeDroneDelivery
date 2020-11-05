using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcmeDroneDeliveryService.ViewModels;

namespace AcmeDroneDeliveryService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {

            };

            return View(homeViewModel);
        }
    }
}
