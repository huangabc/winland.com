using Abp.AspNetCore.Mvc.Views;

namespace win-land.com.Web.Views
{
    public abstract class comRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected comRazorPage()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}
