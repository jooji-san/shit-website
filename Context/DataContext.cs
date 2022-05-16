using Assignment_5.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_5.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ContactModel> contactForms { get; set; }
    }
}
