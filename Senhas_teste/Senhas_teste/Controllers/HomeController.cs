using Senhas_teste.DAL;
using Senhas_teste.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;
using static Senhas_teste.Models.SenhaModel;

namespace Senhas_teste.Controllers
{
    public class HomeController : Controller
    {

        private SenhadbContext db = new SenhadbContext();
        private static List<SenhaModel> senhasA = new List<SenhaModel>();
        private static List<SenhaModel> senhasB = new List<SenhaModel>();
        private static List<SenhaModel> senhasC = new List<SenhaModel>();
        private static List<SenhaModel> senhasD = new List<SenhaModel>();
        private static List<SenhaModel> senhasE = new List<SenhaModel>();

        public ActionResult Index(string name, int numTimes = 1)
        {
            return View();
            //return "É" + Request.QueryString["nome"] + ".";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TirarSenha()
        {
            return View();
        }

        public ActionResult SenhaGerada()
        {
            String tipo = Request.QueryString["tipo"];
            SenhaModel senha = null;

            //Add all type-A queue ticket to de colection senhasA, from the DB. 
            foreach (SenhaModel senhaIt in db.Senhas)
            {
                if (senhaIt.TipoDeSenha == SenhaModel.Tipo.A)
                {
                    if (!senhasA.Exists(x => x.ID == senhaIt.ID))
                        senhasA.Add(senhaIt);
                }
            }
            //#
            //Add all type-B queue ticket to de colection senhasB, from the DB. 
            foreach (SenhaModel senhaIt in db.Senhas)
            {
                if (senhaIt.TipoDeSenha == SenhaModel.Tipo.B)
                {
                    if (!senhasB.Exists(x => x.ID == senhaIt.ID))
                        senhasB.Add(senhaIt);
                }
            }
            //#
            //Add all type-C queue ticket to de colection senhasC, from the DB. 
            foreach (SenhaModel senhaIt in db.Senhas)
            {
                if (senhaIt.TipoDeSenha == SenhaModel.Tipo.C)
                {
                    if (!senhasC.Exists(x => x.ID == senhaIt.ID))
                        senhasC.Add(senhaIt);
                }
            }
            //#
            //Add all type-D queue ticket to de colection senhasD, from the DB. 
            foreach (SenhaModel senhaIt in db.Senhas)
            {
                if (senhaIt.TipoDeSenha == SenhaModel.Tipo.D)
                {
                    if (!senhasD.Exists(x => x.ID == senhaIt.ID))
                        senhasD.Add(senhaIt);
                }
            }
            //#
            //Add all type-A queue ticket to de colection senhasA, from the DB. 
            foreach (SenhaModel senhaIt in db.Senhas)
            {
                if (senhaIt.TipoDeSenha == SenhaModel.Tipo.E)
                {
                    if (!senhasE.Exists(x => x.ID == senhaIt.ID))
                        senhasE.Add(senhaIt);
                }
            }
            //#

            switch (tipo)
            {
                case "0":
                    senha = new SenhaModel { TipoDeSenha = Tipo.A, EstadoDeAtendimento = Estado.NaoCHAMADA, DataDeEmissao = DateTime.Now, NumeroDaSenha = (senhasA.Count + 1) };
                    senhasA.Add(senha);
                    break;
                case "1":
                    senha = new SenhaModel { TipoDeSenha = Tipo.B, EstadoDeAtendimento = Estado.NaoCHAMADA, DataDeEmissao = DateTime.Now, NumeroDaSenha = (senhasB.Count + 1) };
                    senhasB.Add(senha);
                    break;
                case "2":
                    senha = new SenhaModel { TipoDeSenha = Tipo.C, EstadoDeAtendimento = Estado.NaoCHAMADA, DataDeEmissao = DateTime.Now, NumeroDaSenha = (senhasC.Count + 1) };
                    senhasC.Add(senha);
                    break;
                case "3":
                    senha = new SenhaModel { TipoDeSenha = Tipo.D, EstadoDeAtendimento = Estado.NaoCHAMADA, DataDeEmissao = DateTime.Now, NumeroDaSenha = (senhasD.Count + 1) };
                    senhasD.Add(senha);
                    break;
                case "4":
                    senha = new SenhaModel { TipoDeSenha = Tipo.E, EstadoDeAtendimento = Estado.NaoCHAMADA, DataDeEmissao = DateTime.Now, NumeroDaSenha = (senhasE.Count + 1) };
                    senhasE.Add(senha);
                    break;
                default: return HttpNotFound();
            }

                db.Senhas.Add(senha);
                db.SaveChanges();
                return View(senha);
        }
    }
}