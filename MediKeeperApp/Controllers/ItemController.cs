using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Manager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MediKeeperApp.Controllers
{
    public class ItemController : Controller
    {
        private IConfiguration configuration;
        private APIManger mgr;

        public ItemController(IConfiguration IConfig)
        {
            configuration = IConfig;
            mgr = new APIManger(configuration.GetSection("EndPoints").GetSection("MediKeeperBaseAPI").Value);
        }

        // GET: Item
        public ActionResult Index()
        {
            ItemCollection res = mgr.GetAllItems();
            return View(res);
        }

        public ActionResult Items()
        {
            ItemCollection res = mgr.GetItems();
            return View(res);
        }

        public ActionResult ItemsByName(IndexItem item)
        {
            Item res = mgr.ItemsByName(item.ItemName);
            return View(res);
        }


        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item obj)
        {
            try
            {
                //APIManger mgr = new APIManger();

                mgr.CreateItem(obj);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            ItemCollection res = mgr.GetAllItems();
            Item item = res.ItemCol.FirstOrDefault(m => Convert.ToInt32(m.ID) == id);
            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Item obj)
        {
            try
            {
                mgr.UpdateItem(obj);
            
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(string id)
        {
            mgr.DeleteItem(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}