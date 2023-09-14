using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebDemoMVC.EntitiesFrameWork.Entites;

namespace WebDemoMVC.EntitiesFrameWork
{
    public class BlogContext: DbContext
    {
        public BlogContext() : base("ManagerBlog")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext,config>(this));
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}