using Abp.Web.Mvc.Views;

namespace SamleTaskDemo.Web.Views
{
    public abstract class SamleTaskDemoWebViewPageBase : SamleTaskDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class SamleTaskDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SamleTaskDemoWebViewPageBase()
        {
            LocalizationSourceName = SamleTaskDemoConsts.LocalizationSourceName;
        }
    }
}