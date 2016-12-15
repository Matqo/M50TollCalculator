using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M50TollCharges.Models;
namespace M50TollCharges.Controllers
{
    public class M50TollController : Controller
    {
        // GET: M50Toll
        [HttpGet]
        public ActionResult CalculateToll()
        {
            // Creating default model to display car without eTag
            var m50 = new M50TollModel()
            {
                vType = "Car",
                eTag = "Not Present"
            };
            //Appending dropdowns to view
            ViewBag.eTag = new SelectList(M50TollModel.electronicTag);
            ViewBag.vType = new SelectList(M50TollModel.vehicleType);
            //returning default model
            return View(m50);
        }

        //Post result to same page
        [HttpPost]
        public ActionResult CalculateToll(M50TollModel m50)
        {
            //Dropdowns for posted view, to allow re-submission
            ViewBag.eTag = new SelectList(M50TollModel.electronicTag);
            ViewBag.vType = new SelectList(M50TollModel.vehicleType);
            //returning posted model
            return View(m50);
        }



    }
}