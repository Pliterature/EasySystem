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
    	 public class ReportController : Controller
        {
            private IReportService ReportService = Container.Resolve<IReportService>();
            // GET: Report
            public ActionResult Report()
            {
                List<Report> list = ReportService.GetModels(p => true).ToList();
                return View(list);
            }
            public ActionResult Add(Report Report)
            {
                if (ReportService.Add(Report))
                {
                    return Redirect("Report");
                }
                else
                {
                    return Content("no");
                }
            }
            public ActionResult Update(Report Report)
            {
                if (ReportService.Update(Report))
                {
                    return Redirect("Report");
                }
                else
                {
                    return Content("no");
                }
            }
            public ActionResult Delete(int id)
            {
                var Report = ReportService.GetModels(p => p.id == id).FirstOrDefault();
                if (ReportService.Delete(Report))
                {
                    return Redirect("Report");
                }
                else
                {
                    return Content("no");
                }
            }
        }
    
}
