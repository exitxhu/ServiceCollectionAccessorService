using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ServiceCollectionAccessorService
{
    public static class DiInjector
    {
        public static IServiceCollection AddServiceCollectionAccessor(this IServiceCollection services)
        {
            services.AddScoped(n => new ServiceCollectionAccessor(services));
            services.BuildServiceProvider().GetRequiredService<ServiceCollectionAccessor>();
            return services;
        }

    }
}
