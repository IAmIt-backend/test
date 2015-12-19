using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start("http://localhost:9000", appBuilder =>
            {
                var configuation = new HttpConfiguration();
                configuation.MapHttpAttributeRoutes();

                appBuilder
                    .UseNinjectMiddleware(CreateKernel)
                    .UseNinjectWebApi(configuation);
            });

            Console.ReadKey();

        }

        static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IService>().To<Service>();
            kernel.Bind<Service>().ToSelf();

            return kernel;
        }
    }
}
