﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Florence.Controllers
{
    [Authorize]
    public class PerformanceEvaluationController : Controller
    {
        // GET: PerformanceEvaluation
        public ActionResult Index()
        {
            return View(PerformanceEvaluation.GetAll());
        }

        // GET: PerformanceEvaluation/Details/5
        public ActionResult Details(int id)
        {
            return View(PerformanceEvaluation.GetById(id));
        }

        // GET: PerformanceEvaluation/Create
        public ActionResult Create()
        {
            return View(new PerformanceEvaluation());
        }

        // POST: PerformanceEvaluation/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
				var model = new PerformanceEvaluation();
                TryUpdateModel(model);
                model.CreatedAt = DateTime.Now;
                model.CreatedBy = SessionItems.CurrentUser.UserID;
                model.Insert();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PerformanceEvaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View(PerformanceEvaluation.GetById(id));
        }

        // POST: PerformanceEvaluation/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
				var model = PerformanceEvaluation.GetById(id);
				TryUpdateModel(model);
                model.SaveOrUpDate();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PerformanceEvaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PerformanceEvaluation/Delete/5
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
