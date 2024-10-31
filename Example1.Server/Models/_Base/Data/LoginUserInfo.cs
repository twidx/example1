namespace Example1.Server.Models._Base.Data
{
    public class LoginUserInfo
    {
        /// <summary>
        /// 是否登入
        /// </summary>
        public bool IsLogin { get; set; } = false;

        /// <summary>
        /// 登入者帳號
        /// </summary>
        public string? AccountNo { get; set; }
    }
}
