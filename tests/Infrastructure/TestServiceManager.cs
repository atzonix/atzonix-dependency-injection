using Microsoft.Extensions.DependencyInjection;

namespace Atzonix.DependencyInjection.Tests.Infrastructure
{
    internal class TestServiceManager : ServiceManagerBase
    {
        protected override ServiceBuilderBase CreateServiceBuilder(IServiceCollection serviceCollection)
        {
            return new TestServiceBuilder(serviceCollection);
        }
    }
}