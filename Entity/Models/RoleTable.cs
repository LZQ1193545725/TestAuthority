using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 角色表
    /// </summary>
    public partial class RoleTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 角色名
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public bool IsUsed { get; set; }
    }
}
