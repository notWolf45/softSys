using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace softSys_1.Models
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DelivStore>().HasKey(s => new {s.StoresID, s.delivsID});
		}
		
		public DbSet<Stores> Stores {get; set;}
        public DbSet<delivs> deliv {get; set;}
        public DbSet<users> users {get; set;}
		public DbSet<DelivStore> DelivStore {get; set;}
	}
}