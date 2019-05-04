namespace EA.TMS.DataAccess.Core
{
    using Common.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TMS;Integrated Security=False; User Id=sa; Password=0101; Timeout=500000;");
        //}
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
        public virtual void Save()
        {
            base.SaveChanges();
        }
        #region Entities representing Database Objects
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobTask> JobTask { get; set; }
        public DbSet<JobWorker> JobWorker { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<ServiceRequest> ServiceRequest { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        #endregion

        
    }
}