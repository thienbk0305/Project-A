using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebDemoMVC.EntitiesFrameWork.Entites;
using WebDemoMVC.Migrations;

namespace WebDemoMVC.EntitiesFrameWork
{
    public class BlogContext: DbContext
    {
        public BlogContext() : base("ManagerBlog")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>());
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}