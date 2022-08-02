using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleModelsinSingleView.Models;

namespace MultipleModelsinSingleView.Controllers
{
    public class MultipleModelsinSingleViewController : Controller
    {
        // GET: ExpandoObject
        public ActionResult UseExpandoObject()
        {
            ViewBag.Message = "Using ExpandoObject";
            dynamic mymodel = new ExpandoObject();
            mymodel.Members = DBContext.GetMembers();
            mymodel.Schemes = DBContext.GetSchemes();
            return View(mymodel);
        }

        // GET: ViewModel
        public ActionResult UseViewModel()
        {
            ViewBag.Message = "Using ViewModel";
            ViewModel mymodel = new ViewModel();
            mymodel.Schemes = DBContext.GetSchemes();
            mymodel.Members = DBContext.GetMembers();
            return View(mymodel);
        }

        // GET: ViewData
        public ActionResult UseViewData()
        {
            ViewBag.Message = "Using ViewData";
            ViewData["Schemes"] = DBContext.GetSchemes();
            ViewData["Members"] = DBContext.GetMembers();
            return View();
        }

        // GET: ViewBag
        public ActionResult UseViewbag()
        {
            ViewBag.Message = "Using Viewbag";
            ViewBag.Schemes = DBContext.GetSchemes();
            ViewBag.Members = DBContext.GetMembers();
            return View();
        }
        // GET: Tuple
        public ActionResult UseTuple()
        {
            ViewBag.Message = "Using Tuple";
            var tupleModel = new Tuple<List<Scheme>, List<Member>>(
                DBContext.GetSchemes(), DBContext.GetMembers());
            return View(tupleModel);
        }

        // GET: PartialView
        public ActionResult UsePartialView()
        {
            ViewBag.Message = "Using Render Action Method (Partial View)";
            return View();
        }

        public PartialViewResult RenderScheme()
        {
            return PartialView(DBContext.GetSchemes());
        }

        public PartialViewResult RenderMember()
        {
            return PartialView(DBContext.GetMembers());
        }
    }
}