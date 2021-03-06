﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Florence.Controllers
{
    [Authorize]
    public class ProvidentFundController : Controller
    {
        // GET: ProvidentFund
        public ActionResult Index()
        {
            return View(ProvidentFund.GetAll());
        }

        // GET: ProvidentFund/Details/5
        public ActionResult Details(int id)
        {
            return View(ProvidentFund.GetById(id));
        }

        // GET: ProvidentFund/Create
        public ActionResult Create()
        {
            return View(new ProvidentFund());
        }

        // POST: ProvidentFund/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
				var model = new ProvidentFund();
                TryUpdateModel(model);
                model.Insert();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProvidentFund/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ProvidentFund.GetById(id));
        }

        // POST: ProvidentFund/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
				var model = ProvidentFund.GetById(id);
				TryUpdateModel(model);
                model.SaveOrUpDate();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProvidentFund/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProvidentFund/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
