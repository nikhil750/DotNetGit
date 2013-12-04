using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInfo.Models.Nhibernate
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            Configuration nHiberConfig = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\hibernate.cfg.xml");
            nHiberConfig.Configure(configurationPath);

            var employeeConfigurationPath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\Employee.hbm.xml");
            nHiberConfig.AddFile(employeeConfigurationPath);
            
            ISessionFactory sessionFactory = nHiberConfig.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}