using Autofac;
using Czar.Cms.Core.Repository;
using Czar.Cms.Repository.SqlServer;
using Czar.Cms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Czar.Cms.Admin
{
    public class Evolution : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注入Data层的Repository类
            //builder.RegisterGeneric(typeof(BaseRepository<,>)).As(typeof(IBaseRepository<,>)).InstancePerDependency();
            //批量注入Repository层的类
            builder.RegisterAssemblyTypes(typeof(ManagerRepository).Assembly)
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces();
            ////批量注入Service层的类
            builder.RegisterAssemblyTypes(typeof(ManagerRoleService).Assembly)
                 .Where(t => t.Name.EndsWith("Service"))
                 .AsImplementedInterfaces();
        }
    }
}
