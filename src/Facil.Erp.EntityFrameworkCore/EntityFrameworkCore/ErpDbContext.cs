using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Facil.Erp.Authorization.Roles;
using Facil.Erp.Authorization.Users;
using Facil.Erp.MultiTenancy;

namespace Facil.Erp.EntityFrameworkCore
{
    public class ErpDbContext : AbpZeroDbContext<Tenant, Role, User, ErpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ErpDbContext(DbContextOptions<ErpDbContext> options)
            : base(options)
        {
        }
    }
}
