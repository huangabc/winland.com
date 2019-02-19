using Abp.Modules;
using Abp.Reflection.Extensions;
using win-land.com.Localization;

namespace win-land.com
{
    public class comCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            comLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(comCoreModule).GetAssembly());
        }
    }
}