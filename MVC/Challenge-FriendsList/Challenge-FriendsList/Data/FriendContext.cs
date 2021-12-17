using Microsoft.EntityFrameworkCore;
using Challenge_FriendsList.Models;

namespace Challenge_FriendsList.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {

        }
        public DbSet<Friend> Friend { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
             new Friend() { id = 1, friendName = "John", place = "Boston", age = 23, occupation = "Engineer", sport = "Baseball"},
             new Friend() { id = 2, friendName = "Dan", place = "Honolulu", age = 30, occupation = "Lawyer", sport = "Football"},
             new Friend() { id = 3, friendName = "Sandy", place = "Bikini Bottom", age = 28, occupation = "Doctor", sport = "Soccer"}
            );
        }
        
    }
}
