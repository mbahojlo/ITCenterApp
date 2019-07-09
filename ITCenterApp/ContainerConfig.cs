using Autofac;
using ITCenterApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCenterApp
{
    public static class ContainerConfig
    {
            public static IContainer Configure()
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<DatabaseManager>().As<IDatabaseManager>();
                builder.RegisterType<MainApp>().As<IMainApp>();
                return builder.Build();
            }
        
    }
}
