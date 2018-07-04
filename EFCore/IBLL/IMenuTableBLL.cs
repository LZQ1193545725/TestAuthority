using DoMain.IRepository;
using EFCore.ModelViews;
using Entity.Models;
using System.Collections.Generic;

namespace EFCore.IBLL
{
    public interface IMenuTableBLL:IBaseRepository<MenuTable>
    {
        List<MenusView> GetMenus(UserTable user);
    }
}
