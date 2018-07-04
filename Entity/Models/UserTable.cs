using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    public partial class UserTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public bool IsUsed { get; set; }
    }
}
