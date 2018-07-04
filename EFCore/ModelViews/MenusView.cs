using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace EFCore.ModelViews
{
    public class MenusView
    {
        public MenusView()
        {
            Children = new List<MenuTable>();
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public System.Guid ParentId { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 菜单名
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public bool IsUsed { get; set; }

        public List<MenuTable> Children { get; set; }
    }
}
