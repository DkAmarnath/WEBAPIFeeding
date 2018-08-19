using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Newtonsoft.Json;

using System.Web;
using System.Web.Mvc;

namespace WebApiFeeding.Models
{
    public class UsersRepository : ApiController
    {
        private static USERSEntities  dataContext = new USERSEntities();
       // USERSEntities u = new USERSEntities();
        //public class Users { 
        // int ID;
        //string UserName;
        //string Password;
        //int Userid;

        //}
        // [HttpPost]
        public class users{
            string username {get;set;}
            int userid{get;set;}
        }
      //  public static List<users> GetAllEmployees(string username, string password)
       // {
         //   List<users> u=new List<users>() ;
            //dataContext.Customers
            // users u1  =(dataContext.Proc_UserLogin(username, password));
            //if (query[0].ToString().Count()>0)
            //return query[0].ToString();
           // return "";
           // return Request.CreateResponse(HttpStatusCode.OK, query[0].ToString());
            //var b= JsonConvert.SerializeObject(query[0].ToList());
            //return Request.CreateResponse(HttpStatusCode.OK, b);
            //HttpRequestMessage ne=new HttpRequestMessage();
            //var configuration = new HttpConfiguration();
            //ne.SetConfiguration(configuration);
           // var response=ne.CreateResponse(HttpStatusCode.OK,"Hello AMarnath");
            //return Json(b);
           // return Json(b, JsonRequestBehavior.AllowGet);
            //var b = dataContext.getUserDetails(username, password);
            //return u;
            //return u;
        //}
    }
}