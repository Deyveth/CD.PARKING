using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.STORE.Security
{
    public class UserInfo
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long CompanyId { get; set; }
        public long ProfileId { get; set; }
        public long GroupId { get; set; }
        public long EmployeeId { get; set; } = 0;
    }
}
