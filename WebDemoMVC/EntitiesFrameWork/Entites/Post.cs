using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemoMVC.EntitiesFrameWork.Entites
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedUser { get; set; }
        public string PostImage { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}