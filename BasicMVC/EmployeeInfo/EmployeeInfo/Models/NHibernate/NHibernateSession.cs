using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInfo.Models.NHibernate
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var nHConfig = new Configuration();
            var configurationPath= HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\hibernate.cfg.xml");
            nHConfig.Configure(configurationPath);

            var employeeConfig = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\EmployeeBranch.hbm.xml");
            nHConfig.AddFile(employeeConfig);
            ISessionFactory sessionFactory = nHConfig.BuildSessionFactory();
            
            return sessionFactory.OpenSession();
        }
    }
}