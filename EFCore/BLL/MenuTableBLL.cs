using DoMain.Repository;
using EFCore.IBLL;
using Entity.Models;
using EFCore.ModelViews;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EFCore.BLL
{
    public class MenuTableBLL:BaseRepository<MenuTable>,IMenuTableBLL
    {
        private IUserAndRoleBLL _iUserAndRoleBLL;
        private IAuthorityTableBLL _iAuthorityTableBLL;
        public MenuTableBLL(IUserAndRoleBLL iUserAndRoleBLL, IAuthorityTableBLL iAuthorityTableBLL)
        {
            _iAuthorityTableBLL = iAuthorityTableBLL;
            _iUserAndRoleBLL = iUserAndRoleBLL;
        }
        /// <summary>
        /// 获取对应用户的菜单
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<MenusView> GetMenus(UserTable user)
        {
            List<MenuTable> list = new List<MenuTable>();
            if (user.UserName == "admin")
            {
                list = GetList(p => p.IsUsed == true);
            }
            else
            {
                list = (from a in _iUserAndRoleBLL.GetList()
                        join b in _iAuthorityTableBLL.GetList() on a.RoleId equals b.RoleId
                        join c in GetList(p => p.IsUsed == true) on b.MenuId equals c.Id
                        where a.UserId==user.Id
                        select c).ToList();
            }
            List<MenusView> view = new List<MenusView>();
            list.Where(p => p.ParentId == new Guid()).ToList().ForEach(p=>{
                MenusView model = new MenusView() { Id = p.Id, Url = p.Url, IsUsed = p.IsUsed, MenuName = p.MenuName, ParentId = p.ParentId };
                GetChildMenus(ref model, list,model.Id);
                view.Add(model);
            });
            return view;
        }

        public void GetChildMenus(ref MenusView view,List<MenuTable> list,Guid id)
        {
            view.Children = list.Where(p => p.ParentId == id).ToList();
        }
    }
}
