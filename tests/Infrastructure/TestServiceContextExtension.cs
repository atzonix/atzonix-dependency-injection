using Microsoft.Extensions.DependencyInjection;

namespace Atzonix.DependencyInjection.Tests.Infrastructure
{
    internal class TestServiceContextExtension : IServiceContextExtension
    {
        public void AddServices(IServiceCollection services)
        {
            // intentionally empty — used only to affect cache key
        }
    }
}