using Example1.Server.Models._Base;
using Example1.Server.Models.Auth.Data;

namespace Example1.Server.Models.Auth
{
    /// <summary>
    /// Token驗證
    /// </summary>
    public class Token_VModel : Base_VModel
    {
        /// <summary>
        /// 登入者資訊
        /// </summary>
        public UserInfo? User { get; set; }
    }
}
