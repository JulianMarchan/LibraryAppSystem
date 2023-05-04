using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppSystem.EntityFrameworkCore
{
    public static class LibraryAppSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryAppSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryAppSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
