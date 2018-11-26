using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SamleTaskDemo.EntityFramework;

namespace SamleTaskDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SamleTaskDemoCoreModule))]
    public class SamleTaskDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SamleTaskDemoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
