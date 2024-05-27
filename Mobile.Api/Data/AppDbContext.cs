using Microsoft.EntityFrameworkCore;
using Mobile.Data;
using System.Collections.Generic;

namespace Mobile.Api.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Registration> Registrations { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<TokenInfo> TokenInfo { get; set; }
	}
}
