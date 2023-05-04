using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryAppSystem.EntityFrameworkCore;
using LibraryAppSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibraryAppSystem.Web.Tests
{
    [DependsOn(
        typeof(LibraryAppSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LibraryAppSystemWebTestModule : AbpModule
    {
        public LibraryAppSystemWebTestModule(LibraryAppSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryAppSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LibraryAppSystemWebMvcModule).Assembly);
        }
    }
}