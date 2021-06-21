using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proto.DIscratch;

//meh, I'm allowed to place my half-baked extension methods into the ms namespace, cool
namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyConfigServiceCollectionExtension
    {
        //public static IServiceCollection ConfigureByExtension (this IServiceCollection services, IConfiguration config) - this "IConfiguration config" - I don't know what it does.
        public static IServiceCollection ConfigureByExtension (this IServiceCollection services)
        {

            services.AddScoped<IMyDependency, MyDependency>();
            services.AddScoped<IMyDependency, MyDependency2>();
            //I have no idea what this "Configure" does
            //services.Configure<ColorOptions>(
            //    config.GetSection(ColorOptions.Color));
            return services;
        }
    }
}
