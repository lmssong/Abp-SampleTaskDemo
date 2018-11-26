using System.Threading.Tasks;
using Abp.Application.Services;
using SamleTaskDemo.Configuration.Dto;

namespace SamleTaskDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}