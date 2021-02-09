using Microsoft.EntityFrameworkCore;

namespace QuickSoft.InvoiceManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}