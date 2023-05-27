using Microsoft.EntityFrameworkCore;

namespace E_Market_.Net_Core.Models.DB_Classes
{
    public class MarketContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-37H7N8V\SQLEXPRESS;Initial Catalog=EMarketDb;Integrated Security=SSPI;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-37H7N8V\SQLEXPRESS;Database=MarketDb;Trusted_Connection=True;");
            //optionsBuilder.UseMySQL(@"server=localhost;port=3306;database=MarketDb;user=root;password=12345");
        }


    }
}
