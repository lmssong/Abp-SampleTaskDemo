using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SamleTaskDemo.EntityFramework;

namespace SamleTaskDemo.Migrator
{
    [DependsOn(typeof(SamleTaskDemoDataModule))]
    public class SamleTaskDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SamleTaskDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}