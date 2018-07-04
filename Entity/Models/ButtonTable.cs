using System;
using System.Collections.Generic;

namespace Entity.Models
{
    /// <summary>
    /// 按钮表
    /// </summary>
    public partial class ButtonTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Guid Id { get; set; }
        /// <summary>
        /// 控件名称
        /// </summary>
        public string ButtonName { get; set; }
        /// <summary>
        /// 控件类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public bool IsUsed { get; set; }
    }
}
