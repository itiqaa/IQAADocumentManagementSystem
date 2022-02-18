using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IQAADocumentManagementSystem.Models;

namespace IQAADocumentManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IQAADocumentManagementSystem.Models.Employee> Employee { get; set; }
        public DbSet<IQAADocumentManagementSystem.Models.Document> Document { get; set; }
    }
}