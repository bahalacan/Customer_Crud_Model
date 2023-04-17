using Customer.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DataAccess
{
	public class CustomerContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CustomerDatabase;Trusted_Connection=true");
		}

		public DbSet<Customerr> Customers { get; set; } // Customer gives compiler error

	}
}
