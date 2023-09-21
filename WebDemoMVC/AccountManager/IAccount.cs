using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemoMVC.EntitiesFrameWork.Entites;

namespace WebDemoMVC.User
{
    public interface IAccount
    {
        List<Account> Account_GetList();
        int Account_InsertUpdate(Account account, int isUpdate);
        int Account_Delete(string username);
    }
}
