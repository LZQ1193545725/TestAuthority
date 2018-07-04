using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public partial class MenuTable
    {
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
    }
}
