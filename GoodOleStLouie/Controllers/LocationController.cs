using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodOleStLouie.Data;
using GoodOleStLouie.Models;
using GoodOleStLouie.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GoodOleStLouie.Controllers
{
    public class LocationController : Controller
    {
        private ApplicationDbContext context;
        public LocationController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Location> locations = context.Locations.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            LocationCreateViewModel locationCreateViewModel = new LocationCreateViewModel();
            return View(locationCreateViewModel);
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            //Location newLocation = new Location
            
               // Name = locationCreateViewModel.Name,
               // Description = locationCreateViewModel.Description
            return View();
        }
        /* context.Add(location);
         context.SaveChanges();
         return RedirectToAction(nameof(Index))*/
        
        //revamp to use in view model

    }

}