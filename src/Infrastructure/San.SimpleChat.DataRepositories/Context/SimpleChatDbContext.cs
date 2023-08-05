using San.SimpleChat.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace San.SimpleChat.DataRepositories.Context
{
    public class SimpleChatDbContext: IdentityDbContext
    {
        public SimpleChatDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
