using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemoMVC.EntitiesFrameWork.Entites;

namespace WebDemoMVC.PostManager
{
    public interface IPost
    {
        List<Post> Post_GetList(int postId, string name);
        int Post_InsertUpdate(Post post, int isUpdate);
        int Post_Delete(int postId);
    }
}
