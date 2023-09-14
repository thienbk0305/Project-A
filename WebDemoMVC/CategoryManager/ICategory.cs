using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemoMVC.EntitiesFrameWork.Entites;

namespace WebDemoMVC.CategoryManager
{
    public interface ICategory
    {
        List<Category> Categories_GetList(int cateId, string name);
        int Category_InsertUpdate(Category category, int isUpdate);
        int Category_Delete(int cateId);
    }
}
