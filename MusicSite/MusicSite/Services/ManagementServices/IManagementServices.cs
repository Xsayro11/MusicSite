using MusicSite.Services.ManagementServices.AddServices;
using MusicSite.Services.ManagementServices.DeleteServices;
using MusicSite.Services.ManagementServices.EditServices;

namespace MusicSite.Services.ManagementServices
{
    public interface IManagementServices<T> where T : class
    {
        IAddService<T> AddService { get; }
        IEditService<T> EditService { get; }
        IDeleteService<T> DeleteService { get; }
    }
}