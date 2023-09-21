using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using WebDemoMVC.User;

namespace WebDemoMVC.AccountManager
{
    public class AccountManager : IAccount
    {
        BlogContext dbContext = new BlogContext();
        //public int Account_Delete(int accountId)
        //{
        //    try
        //    { 
        //        var accountRemove = dbContext.Account.Where(c => c.Id == accountId).FirstOrDefault();

        //        dbContext.Account.Remove(accountRemove);
        //        return dbContext.SaveChanges();
        //    }
        //    catch (Exception)
        //    {

        //        return -1;
        //    }
        //}

        public List<Account> Account_GetList()
        {
            var list = new List<Account>();
            try
            {
                list = dbContext.Account.ToList();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return list;
        }

        public int Account_InsertUpdate(Account account, int isUpdate)
        {
            try
            {
                if (isUpdate == 0)
                {
                    // INSERT
                    var checkExist = dbContext.Account.ToList().FindAll(s => s.Username == account.Username);
                    if (checkExist.Count > 0)
                    {
                        // đã tồn tại rồi
                        return -1;
                    }
                    
                    dbContext.Account.Add(account);
                }
                else
                {
                    // UPDATE
                    var acc = dbContext.Account.ToList().FindAll(s => s.Username == account.Username).FirstOrDefault();
                    acc.Password = account.Password;
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