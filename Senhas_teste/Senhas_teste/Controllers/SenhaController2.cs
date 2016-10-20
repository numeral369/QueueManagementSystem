using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Senhas_teste.Models;

namespace Senhas_teste.Controllers
{
    public class SenhaController2 : Controller
    {
        /*private SenhadbContext db = new SenhadbContext();

        // GET: SenhaController2
        public ActionResult Index()
        {
            return View(db.SenhaModels.ToList());
        }

        // GET: SenhaController2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SenhaModel senhaModel = db.SenhaModels.Find(id);
            if (senhaModel == null)
            {
                return HttpNotFound();
            }
            return View(senhaModel);
        }

        // GET: SenhaController2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SenhaController2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TipoDeSenha,EstadoDeAtendimento,DataDeEmissao,NumeroDaSenha")] SenhaModel senhaModel)
        {
            if (ModelState.IsValid)
            {
                db.SenhaModels.Add(senhaModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(senhaModel);
        }

        // GET: SenhaController2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SenhaModel senhaModel = db.SenhaModels.Find(id);
            if (senhaModel == null)
            {
                return HttpNotFound();
            }
            return View(senhaModel);
        }

        // POST: SenhaController2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TipoDeSenha,EstadoDeAtendimento,DataDeEmissao,NumeroDaSenha")] SenhaModel senhaModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(senhaModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(senhaModel);
        }

        // GET: SenhaController2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SenhaModel senhaModel = db.SenhaModels.Find(id);
            if (senhaModel == null)
            {
                return HttpNotFound();
            }
            return View(senhaModel);
        }

        // POST: SenhaController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SenhaModel senhaModel = db.SenhaModels.Find(id);
            db.SenhaModels.Remove(senhaModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }*/
    }
}
