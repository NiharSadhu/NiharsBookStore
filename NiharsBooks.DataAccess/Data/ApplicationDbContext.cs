using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NiharsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NiharsBookStore.DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Category> Categories { get; set; }
	}
}
