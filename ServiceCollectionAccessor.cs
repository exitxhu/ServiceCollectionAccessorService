using Microsoft.Extensions.DependencyInjection;

namespace ServiceCollectionAccessorService
{
    public class ServiceCollectionAccessor
    {
        public static IServiceCollection Services { get; private set; }

        public ServiceCollectionAccessor(IServiceCollection services)
        {
            Services = services;
        }
    }
}