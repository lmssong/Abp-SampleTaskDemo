using SamleTaskDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SamleTaskDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SamleTaskDemoDbContext _context;

        public InitialHostDbBuilder(SamleTaskDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
