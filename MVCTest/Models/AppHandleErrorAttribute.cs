using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Models
{
    public class AppHandleErrorAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception Error = filterContext.Exception;
            string Message = Error.Message;//错误信息
            string Url = HttpContext.Current.Request.RawUrl;//错误发生地址
            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult("~/Share/Error/?ErrorMsg=" + Message, true);
            //filterContext.HttpContext.Response.Redirect("~/Share/Error/?ErrorMsg=1");
        }
    }
}