using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Data
{
	class HelloDbContextFactory : IDesignTimeDbContextFactory<HelloDbContext>
	{
		public HelloDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<HelloDbContext>();
			optionsBuilder.UseSqlServer(@"Data Source=SKYM\SQLEXPRESS;Initial Catalog=My31Cafe;Integrated Security=True;");

			return new HelloDbContext(optionsBuilder.Options);
		}
	}
}
