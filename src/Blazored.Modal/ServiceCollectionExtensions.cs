using Blazored.Modal.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazored.Modal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazoredModal(this IServiceCollection services)
        {
            return services.AddScoped<IModalService, ModalService>();
        }

        public static IServiceCollection AddBlazoredModal<TModalInstance>(this IServiceCollection services)
            where TModalInstance : BlazoredModalInstance
        {
            return services.AddScoped<IModalService, ModalService>( x => new ModalService(typeof(TModalInstance)));
        }
    }
}
