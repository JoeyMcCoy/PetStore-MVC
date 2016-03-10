using JoeysPetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JoeysPetStore.Controllers
{
    public class InventoryController : Controller
    {
        private PetDBContext db = new PetDBContext();
        // GET: Inventory
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }
        // GET: /Inventory/Details
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }
    }
}