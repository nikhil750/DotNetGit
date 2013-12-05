using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeInfo.Models;
using EmployeeInfo.Models.NHibernate;
using NHibernate;
using NHibernate.Linq;
namespace EmployeeInfo.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public EmployeeContext eContext = new EmployeeContext();

        public ActionResult Index()
        {
            return View(eContext.employeeModel.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeGit einfo)
        {
            eContext.Entry(einfo).State = System.Data.EntityState.Added;
            eContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Branch()
        {
            using (ISession session =  NHibernateSession.OpenSession())
            {
                var employeeBranch = session.Query<EmployeeBranch>().ToList();
                return View(employeeBranch);
            }
        }

    }
}
