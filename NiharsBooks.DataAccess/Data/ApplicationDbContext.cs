﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NiharsBooks.DataAccess.Repository;
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
		
		public DbSet<CoverType> CoverTypes { get; set; }

		public DbSet<Product> products { get; set; }
	}
}
