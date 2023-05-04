using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryAppSystem.Authorization.Roles;
using LibraryAppSystem.Authorization.Users;
using LibraryAppSystem.MultiTenancy;

namespace LibraryAppSystem.EntityFrameworkCore
{
    public class LibraryAppSystemDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryAppSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LibraryAppSystemDbContext(DbContextOptions<LibraryAppSystemDbContext> options)
            : base(options)
        {
        }
    }
}
