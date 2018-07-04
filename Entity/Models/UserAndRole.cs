using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 用户与角色关系表
    /// </summary>
    public partial class UserAndRole
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public System.Guid UserId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public System.Guid RoleId { get; set; }
    }
}
