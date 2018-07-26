using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using Data.Domain;
namespace Data
{
    public class DwGuitarContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
       
        public DbSet<Author> Posts { get; set; }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DwGuitarContext() : base("DwGuitar")
        {
        }
    }
}