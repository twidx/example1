using Example1.Server.Models._Base;

namespace Example1.Server.Models.Auth
{
    /// <summary>
    /// 登入
    /// </summary>
    public class Login_PModel : Base_PModel
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string? AccountNo { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string? Password { get; set; }
    }
}
