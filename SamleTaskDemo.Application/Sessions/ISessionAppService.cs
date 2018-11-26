using System.Threading.Tasks;
using Abp.Application.Services;
using SamleTaskDemo.Sessions.Dto;

namespace SamleTaskDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
