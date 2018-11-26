using Abp.AutoMapper;
using SamleTaskDemo.Sessions.Dto;

namespace SamleTaskDemo.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}