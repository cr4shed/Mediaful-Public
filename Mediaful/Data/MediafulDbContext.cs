using Mediaful.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mediaful.Data
{
    public class MediafulDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public MediafulDbContext(DbContextOptions<MediafulDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}