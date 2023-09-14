using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace WebDemoMVC.PostManager
{
    public class PostManager : IPost
    {
        BlogContext dbContext = new BlogContext();
        public int Post_Delete(int postId)
        {
            try
            {
                // Bước 1: lấy ra post theo PostId truyền vào 
                var postRemove = dbContext.Post.Where(c => c.PostId == postId).FirstOrDefault();

                // Bước 2 : Xóa
                dbContext.Post.Remove(postRemove);
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public List<Post> Post_GetList(int postId, string name)
        {
            var list = new List<Post>();
            try
            {
                list = dbContext.Post.ToList();
                if (postId > 0)
                {
                    list = list.FindAll(s => s.PostId == postId).ToList();
                }

                if (!string.IsNullOrEmpty(name))
                {
                    list = list.FindAll(s => s.PostName.ToLower().Contains(name)).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return list;
        }

        public int Post_InsertUpdate(Post post, int isUpdate)
        {
            try
            {
                if (isUpdate == 0)
                {
                    // INSERT
                    var checkExist = dbContext.Post.ToList().FindAll(s => s.PostId == post.PostId);
                    if (checkExist.Count > 0)
                    {
                        // đã tồn tại rồi
                        return -1;
                    }

                    dbContext.Post.Add(post);
                }
                else
                {
                    // UPDATE
                    var cate = dbContext.Post.ToList().FindAll(s => s.PostId == post.PostId).FirstOrDefault();
                    cate.PostName = post.PostName;
                }

                return dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}