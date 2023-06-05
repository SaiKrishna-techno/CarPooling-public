using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Ride> Rides { get; set; }

        public DbSet<BookRide> BookedRides { get; set; }

        public DbSet<OfferedRide> OfferedRides { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-NIT4DTQC\\SQLEXPRESS;DataBase=Car-PoolingDb; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //   optionsBuilder.UseSqlServer("Data Source=TL606\\SQLEXPRESS ; Database=Car-PoolingDb;  Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ");
            optionsBuilder.UseMySql($"Server=database-1.cqa8a11cqhws.eu-north-1.rds.amazonaws.com; port=3306; Database=carpooldb; User Id =root; Password=roottoor;", serverVersion, options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: System.TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null)
                );
        }
    }
}
