using System;
using Microsoft.EntityFrameworkCore;
using Vakarkrasti.Models;

namespace Vakarkrasti.Data
{
	public class VKContext : DbContext
	{
		public VKContext(DbContextOptions<VKContext> options) : base(options)
		{
		}

		public DbSet<Houses> House { get; set; }
		public DbSet<Reservations> Reservation { get; set; }
	}
}

