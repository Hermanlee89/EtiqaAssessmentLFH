using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using EtiqaAssessmentLFH.Models;

namespace EtiqaAssessmentLFH.Data
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("UserDatabase");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<userModel> Users
        {
            get; set;
        }
    }
}
