using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCore.IBLL;
using EFCore.ModelViews;
using Entity.Models;

namespace TestAuthority.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        private IMenuTableBLL _iMenuTableBLL;
        public HomeController(IMenuTableBLL iMenuTableBLL)
        {
            _iMenuTableBLL = iMenuTableBLL;
        }
        public ActionResult Index()
        {
            List<MenusView> list = _iMenuTableBLL.GetMenus(Person);
            return View();
        }
        [HttpPost]
        public string GetMenu()
        {

            List<MenusView> list = _iMenuTableBLL.GetMenus(Person);
            return GetJsonString(list);
        }
    }
}