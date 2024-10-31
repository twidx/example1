using Example1.Server.Models._Base;
using Example1.Server.Models.Account.Data;

namespace Example1.Server.Models.Account
{
    /// <summary>
    /// 帳號查詢
    /// </summary>
    public class AccountQuery_VModel : Base_VModel
    {
        public List<AccountItem>? Results { get; set; }
    }
}
