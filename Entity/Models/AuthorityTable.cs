using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 权限表
    /// </summary>
    public partial class AuthorityTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 菜单Id
        /// </summary>
        public System.Guid MenuId { get; set; }
        /// <summary>
        /// 按钮Id
        /// </summary>
        public System.Guid ButtonId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public System.Guid RoleId { get; set; }
    }
}
