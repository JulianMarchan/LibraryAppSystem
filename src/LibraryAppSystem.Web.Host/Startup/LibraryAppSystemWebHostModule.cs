using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryAppSystem.Configuration;

namespace LibraryAppSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(LibraryAppSystemWebCoreModule))]
    public class LibraryAppSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryAppSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryAppSystemWebHostModule).GetAssembly());
        }
    }
}
