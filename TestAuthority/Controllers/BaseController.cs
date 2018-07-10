using EFCore.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Entity.Models;
using System.Web.Routing;

namespace TestAuthority.Controllers
{
    public class BaseController : Controller
    {
        public UserTable Person { get; set; }
        public Message message = new Message();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
            else
            {
                Person = filterContext.HttpContext.Session["user"] as UserTable;
            }
        }
        public string Form(string name)
        {
            return HttpContext.Request.Form[name] == null ? "" : HttpContext.Request.Form[name].ToString();
        }
        public string Query(string name)
        {
            return HttpContext.Request.QueryString[name] == null ? "" : HttpContext.Request.QueryString[name].ToString();
        }
        /// <summary>
        /// 返回json字符串
        /// </summary>
        /// <returns></returns>
        public string GetJsonString(dynamic data)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            return JsonConvert.SerializeObject(data,Formatting.Indented,timeConverter);
        }

        

        public class Message
        {
            public int status { get; set; }
            public string msg { get; set; }
            public object data { get; set; }
        }
    }
}