using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;
using System.Web.Routing;
using DoMain.IRepository;

namespace TestAuthority
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            //获取IAutoInject的Type
            var baseType = typeof(IAutofac);
            //获取所有程序集
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToArray();
            //自动注册接口
            builder.RegisterAssemblyTypes(assemblies).Where(b => b.GetInterfaces().
            Any(c => c == baseType && b != baseType)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //自动注册控制器
            builder.RegisterControllers(assemblies);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
