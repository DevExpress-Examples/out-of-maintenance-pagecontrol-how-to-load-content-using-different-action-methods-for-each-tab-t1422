using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCxGridViewDataBinding.Models;

namespace T142225.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

      
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult TabPage1()
        {
            var model = DateTime.Now;
            return PartialView("PartialView1", model);
        }
        [ValidateInput(false)]
        public ActionResult TabPage2()
        {
            var model = MyModel.GetModelList();
            return PartialView("PartialView2", model);
        }
        public ActionResult TabPage3()
        {
            var model = new MyModel(3);
            return PartialView("PartialView3", model);

        }
        public ActionResult PageControlPartial()
        {
            return PartialView();
        }
        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = MyModel.GetModelList();
            return PartialView("PartialView2", model);
        }
    }
}
