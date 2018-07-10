using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity.Models;
using EFCore.IBLL;

namespace TestAuthority.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private IUserTableBLL _userBLL;
        public LoginController(IUserTableBLL userBLL)
        {
            _userBLL = userBLL;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string LoginCheck()
        {
            BaseController.Message message = new BaseController.Message();
            string userName = Request.Form["userName"];
            var model = _userBLL.GetModel(p => p.UserName == userName);
            if (model == null)
            {
                message.status = 3;
                message.msg = "登录失败";
            }
            else
            {
                Session["user"] = model;
                Session.Timeout = 120;
                message.status = 1;
                message.msg = "登陆成功";
            }
            return new BaseController().GetJsonString(message);
        }
    }
}