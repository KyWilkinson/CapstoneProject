using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Models
{
    public class PlayerProfile : Controller
    {
        // GET: PlayerProfile
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlayerProfile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlayerProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayerProfile/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerProfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerProfile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayerProfile/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
