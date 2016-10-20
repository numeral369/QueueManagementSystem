using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using Senhas_teste.Models;

namespace Senhas_teste.Controllers
{
    public class AtendenteController : Controller
    {
        private SenhadbContext db = new SenhadbContext();
        private static List<SenhaModel> senhasA = new List<SenhaModel>();
        private static List<SenhaModel> senhasB = new List<SenhaModel>();
        private static List<SenhaModel> senhasC = new List<SenhaModel>();
        private static List<SenhaModel> senhasD = new List<SenhaModel>();
        private static List<SenhaModel> senhasE = new List<SenhaModel>();
        private static SenhaModel senhaModelA = null;

        // GET: Atendente/Edit/5
        public ActionResult IndexA(int? id)
        {
            int quantidadeSenhasEmitidas;
            int maximoSenhasHoje;

            //Add all type-A queue ticket to de colection senhasA, from the DB. 
            foreach (SenhaModel senha in db.Senhas)
            {
                if (senha.TipoDeSenha == SenhaModel.Tipo.A)
                {
                    if(!senhasA.Exists(x => x.ID == senha.ID))
                        senhasA.Add(senha);
                }
            }
            //#

            //On the very first load of the page
            if (senhaModelA == null) {
                foreach (SenhaModel senha in senhasA)
                {
                    if (senha.EstadoDeAtendimento == SenhaModel.Estado.NaoCHAMADA)
                    {
                        senhaModelA = senha;
                        break;
                    }
                }
                if (senhaModelA == null)
                    senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhasA.Count-1));
            }
            //#

            //Choose which is the queue ticket to be shown (from senhasA)
            String trocar = Request.QueryString["trocar"];
            switch (trocar)
            {
                case "<":
                    if(senhaModelA.NumeroDaSenha > 1)
                    senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhaModelA.NumeroDaSenha - 1));
                    break;
                case ">":
                    if (senhaModelA.NumeroDaSenha < senhasA.Count)
                        senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhaModelA.NumeroDaSenha + 1));
                    break;
                default:
                    
                    break;
            }
            //#

            String atendimento = Request.QueryString["atendimento"];
            switch (atendimento)
            {
                case "cancelado":
                    //senhaModelA.EstadoDeAtendimento = SenhaModel.Estado.CANCELADA;
                    db.Senhas.Find(senhaModelA.ID).EstadoDeAtendimento = SenhaModel.Estado.CANCELADA;
                    db.SaveChanges();
                    if (senhaModelA.NumeroDaSenha < senhasA.Count)
                        senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhaModelA.NumeroDaSenha + 1));
                    break;
                case "atendido":
                    db.Senhas.Find(senhaModelA.ID).EstadoDeAtendimento = SenhaModel.Estado.ATENDIDA;
                    db.SaveChanges();
                    if (senhaModelA.NumeroDaSenha < senhasA.Count)
                        senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhaModelA.NumeroDaSenha + 1));
                    break;
                case "redirecionado":
                    db.Senhas.Find(senhaModelA.ID).EstadoDeAtendimento = SenhaModel.Estado.REDIRECIONADA;
                    db.SaveChanges();
                    if (senhaModelA.NumeroDaSenha < senhasA.Count)
                        senhaModelA = senhasA.Find(x => x.NumeroDaSenha == (senhaModelA.NumeroDaSenha + 1));
                    break;
                default:

                    break;
            }

            //senhaModel = db.Senhas.Find(1);
            if (senhaModelA == null)
            {
               return HttpNotFound();
            }

            quantidadeSenhasEmitidas = 12;
            ViewData["quantidadeSenhasEmitidas"] = senhasA.Count;
            maximoSenhasHoje = 100;
            ViewData["maximoSenhasHoje"] = maximoSenhasHoje;
            return View(senhaModelA);
        }

        // POST: Atendente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexA([Bind(Include = "ID,TipoDeSenha,EstadoDeAtendimento,DataDeEmissao,NumeroDaSenha")] SenhaModel senhaModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(senhaModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(senhaModel);
        }
    }
}
