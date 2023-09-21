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
            
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}