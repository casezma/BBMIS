using BBMIS.Import;
using BBMIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBMIS.Controllers
{
    public class AnalysisController : Controller
    {
        BBMISContext context = new BBMISContext();

        // GET: Analysis
        public ActionResult Index(string brandSearch, string vehicleSearch)
        {
           


            CarBuildIO carBuildIO = new CarBuildIO();
            carBuildIO.ImportarCarBuild(context);

            ViewBag.Brand = (from m in context.CarBuild
                             select m.Brand).Distinct();

            ViewBag.Vehicle = (from m in context.CarBuild
                               where m.Brand == brandSearch || brandSearch.Equals(null) || brandSearch.Equals("")
                               select m.Vehicle).Distinct();

            var mnemonic = (from m in context.CarBuild
                                              where m.Brand == brandSearch || brandSearch.Equals(null) || brandSearch.Equals("")
                                              where m.Vehicle == vehicleSearch || vehicleSearch.Equals(null) || vehicleSearch.Equals("")
                                              group m by m.Mnemonic_Bodystyle into grp
                                              select grp.FirstOrDefault());

            ViewBag.Mnemonic = mnemonic;
            if (Request.IsAjaxRequest()){
                
                return PartialView("_MnemonicSelection");
            }
                              
            return View();
        }

        public ActionResult _Derivation(string mnemonic_bodystyle) {

           
            var derivation = (from d in context.Derivation.ToList()
                              where d.Mnemonic_Bodystyle.ToString().Equals(mnemonic_bodystyle) || mnemonic_bodystyle.Equals(null) || mnemonic_bodystyle.Equals("") || d.Mnemonic_Bodystyle.Equals(mnemonic_bodystyle)
                              group d by d.Mnemonic_Bodystyle into grp
                              select grp.FirstOrDefault()).ToList();

            ViewBag.Derivation = derivation;
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Derivation");
            }
            return View();
            }

       
    }
}