using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ice_Shapers.Models;
using Microsoft.EntityFrameworkCore;

namespace Ice_Shapers.Data
{
	public class MvcIceContext : DbContext
	{
		public MvcIceContext(DbContextOptions<MvcIceContext> options)
			: base(options)
		{
		}

		public DbSet<Ice> Ice{ get; set; }
	}
}
