//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasySystem.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using EasySystem.IBLL;
    using EasySystem.Model;
    using EasySystem.BLLContainer;
    	 public class ReporttypeController : Controller
        {
            private IReporttypeService ReporttypeService = Container.Resolve<IReporttypeService>();
            // GET: Reporttype
            public ActionResult Reporttype()
            {
                List<Reporttype> list = ReporttypeService.GetModels(p => true).ToList();
                return View(list);
            }
            public ActionResult Add(Reporttype Reporttype)
            {
                if (ReporttypeService.Add(Reporttype))
                {
                    return Redirect("Reporttype");
                }
                else
                {
                    return Content("no");
                }
            }
            public ActionResult Update(Reporttype Reporttype)
            {
                if (ReporttypeService.Update(Reporttype))
                {
                    return Redirect("Reporttype");
                }
                else
                {
                    return Content("no");
                }
            }
            public ActionResult Delete(int id)
            {
                var Reporttype = ReporttypeService.GetModels(p => p.id == id).FirstOrDefault();
                if (ReporttypeService.Delete(Reporttype))
                {
                    return Redirect("Reporttype");
                }
                else
                {
                    return Content("no");
                }
            }
        }
    
}
