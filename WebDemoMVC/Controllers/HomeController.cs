using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using WebDemoMVC.Models;

namespace WebDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string name)
        {
            var model = new List<StudentModels>();

            var dbContext = new StudentDbContext();

            //dbContext.student.Add(new EntitiesFrameWork.Entites.Student { Id = 10, Name = "abc_def14" });
            //dbContext.student.Add(new EntitiesFrameWork.Entites.Student { Id = 11, Name = "abc_def15" });
            //dbContext.student.Add(new EntitiesFrameWork.Entites.Student { Id = 12, Name = "abc_def16" });
            //dbContext.SaveChanges();



            var list_student = dbContext.student.ToList();
            if (list_student.Count > 0)
            {
                for (int i = 0; i < list_student.Count; i++)
                {
                    var item = list_student[i];
                    model.Add(new StudentModels { Id = item.Id, Name = item.Name });
                }
            }


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            var modelBlog = new List<BlogModels>();
            var dbContextBlog = new BlogContext();

            Create some categories data
            dbContextBlog.Categories.Add(new EntitiesFrameWork.Entites.Category
            {
                Name = "Web Development"
            });
            dbContextBlog.Categories.Add(new EntitiesFrameWork.Entites.Category
            {
                Name = "Mobile Development"
            });
            // Create some posts data
            dbContextBlog.Posts.Add(new EntitiesFrameWork.Entites.Post
            {
                Title = "How to Build a Website",
                Content = "This post will teach you how to build a website from scratch.",
                PublishedDate = DateTime.Now,
                CategoryId = 1
            });
            dbContextBlog.Posts.Add(new EntitiesFrameWork.Entites.Post
            {
                Title = "How to Develop an App",
                Content = "This post will teach you how to develop an app for mobile devices.",
                PublishedDate = DateTime.Now,
                CategoryId = 2
            });


            var posts = dbContextBlog.Posts.ToList();

            dbContextBlog.SaveChanges();

            if (posts.Count > 0)
            {
                for (int i = 0; i < posts.Count; i++)
                {
                    var item = posts[i];
                    modelBlog.Add(new BlogModels { 
                        Id = item.Id,
                        Title = item.Title,
                        Content = item.Content,
                        PublishedDate = item.PublishedDate,
                        //CatagoryName = item.CatagoryId.ToString()
                    });
                }
            }


            return View(modelBlog);

        }
    }
}