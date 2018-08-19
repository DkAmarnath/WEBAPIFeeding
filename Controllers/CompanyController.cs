using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApiFeeding.repository;

namespace WebApiFeeding.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //    //// GET: Company
        //    //public ActionResult Index()
        //    //{
        //    //    return View();
        //    //}
        //    #region Global Declaration  
        //    private IRepository<Customers> _Companyrepository = null;  
        //public CompanyController() {
        //    this._Companyrepository = new Repository<Customers>();  
        //}
        //    #endregion
        //    # region Company  
        //    /// <summary>  
        //    /// Get Company List  
        //    /// </summary>  
        //    /// <returns></returns>  
        //    [Route("api/GetCompanies")]  
        //    [HttpGet]  
        //public HttpResponseMessage GetCompanies() {  
        //    var result = _Companyrepository.GetAll();  
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);  
        //    return response;  
        //}  
        ///// <summary>  
        ///// Get Company Detail  
        ///// </summary>  
        ///// <param name="CompanyId"></param>  
        ///// <returns></returns>  
        //[Route("api/GetCompany")]  
        //[HttpGet]  
        //public HttpResponseMessage GetCompany(int CompanyId) {  
        //    var result = _Companyrepository.GetById(CompanyId);  
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);  
        //    return response;  
        //}  
        ///// <summary>  
        ///// Delete Company Detail  
        ///// </summary>  
        ///// <param name="CompanyId"></param>  
        ///// <returns></returns>  
        //[Route("api/DeleteCompany")]  
        //[HttpGet]  
        //public HttpResponseMessage DeleteCompany(int CompanyId) {  
        //    var result = _Companyrepository.Delete(CompanyId);  
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);  
        //    return response;  
        //}  
        ///// <summary>  
        ///// UpdateCompany Detail  
        ///// </summary>  
        ///// <param name="CompanyId"></param>  
        ///// <returns></returns>  
        //[Route("api/UpdateCompany")]  
        //[HttpGet]  
        //public HttpResponseMessage UpdateCompany(Company CompanyDetails) {  
        //    var result = _Companyrepository.Update(CompanyDetails);  
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);  
        //    return response;  
        //}
        //    #endregion  
        //}
    }
}