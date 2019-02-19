using Abp.AspNetCore.Mvc.Controllers;

namespace win-land.com.Web.Controllers
{
    public abstract class comControllerBase: AbpController
    {
        protected comControllerBase()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}