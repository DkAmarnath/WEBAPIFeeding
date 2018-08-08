using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data;
using System.Data.Entity;

namespace WebApiFeeding.Models
{
    public class UsersRepository
    {
        private static USERSEntities  dataContext = new USERSEntities();
       // USERSEntities u = new USERSEntities();
        //public class Users { 
        // int ID;
        //string UserName;
        //string Password;
        //int Userid;

        //}
        public static string GetAllEmployees(string username,string password)
        {
            var query = dataContext.Proc_UserLogin(username, password).ToList();
            if (query[0].ToString().Count()>0)
            return query[0].ToString();
            return "";
        }
    }
}