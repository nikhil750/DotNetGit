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

        public ActionResult CreateBranch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBranch(EmployeeBranch emp)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction sessionTransact = session.BeginTransaction())
                {
                    sessionTransact.Begin();
                    session.Save(emp);
                    sessionTransact.Commit();
                }
            }
            return RedirectToAction("Branch");
        }

        public ActionResult EditBranch(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var employeeBranchEdit = session.Get<EmployeeBranch>(id);
                return View(employeeBranchEdit);
            }
        }

        [HttpPost]
        public ActionResult EditBranch(int id, EmployeeBranch empBranch)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var employeeBranchSelected = session.Get<EmployeeBranch>(id);
                employeeBranchSelected.Branch = empBranch.Branch;

                using (ITransaction ItransactionSesison = session.BeginTransaction())
                {
                    ItransactionSesison.Begin();
                    session.Save(employeeBranchSelected);
                    ItransactionSesison.Commit();
                }
            }
            return RedirectToAction("Branch");
        }


    }
}
