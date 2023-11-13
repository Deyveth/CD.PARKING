using System.Security.Claims;

namespace CD.STORE.Security
{
    public class UserHelper
    {
        public static UserInfo user;
        public static void GetUser(System.Security.Principal.IPrincipal User)
        {
            if (user == null)
            {
                user = new UserInfo();

                if (User.Identity is ClaimsIdentity identity)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                    user.UserId = int.Parse(claims.Where(p => p.Type == "userId").FirstOrDefault()?.Value);
                    user.Username = identity.Name;
                    user.CompanyId = long.Parse(claims.Where(p => p.Type == "companyId").FirstOrDefault()?.Value);
                    user.EmployeeId = long.Parse(claims.Where(p => p.Type == "employeeId").FirstOrDefault()?.Value);
                }
            }
            else
            {
                if (User.Identity is ClaimsIdentity identity)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                    user.UserId = int.Parse(claims.Where(p => p.Type == "userId").FirstOrDefault()?.Value);
                    user.Username = identity.Name;
                    user.CompanyId = long.Parse(claims.Where(p => p.Type == "companyId").FirstOrDefault()?.Value);
                    user.EmployeeId = long.Parse(claims.Where(p => p.Type == "employeeId").FirstOrDefault()?.Value);
                }
            }
        }
    }
}
