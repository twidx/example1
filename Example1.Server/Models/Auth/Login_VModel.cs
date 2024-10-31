using Example1.Server.Models._Base;
using Example1.Server.Models.Auth.Data;

namespace Example1.Server.Models.Auth
{
    /// <summary>
    /// 登入
    /// </summary>
    public class Login_VModel : Base_VModel
    {
        /// <summary>
        /// 登入者資訊
        /// </summary>
        public UserInfo? User { get; set; }

        public string? JwtToken { get; set; }
    }
}
