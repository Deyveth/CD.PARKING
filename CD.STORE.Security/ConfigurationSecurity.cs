using Novell.Directory.Ldap;
using System.Security.Cryptography;

namespace CD.STORE.Security
{
    public class ConfigurationSecurity
    {
        public static bool ValidateUser(string host, string domainName, string username, string password)
        {
            string userDn = $"{username}@{domainName}";
            try
            {
                using var connection = new LdapConnection { SecureSocketLayer = false };
                connection.Connect(host, LdapConnection.DefaultPort);
                connection.Bind(userDn, password);
                if (connection.Bound)
                    return true;
            }
            catch (LdapException)
            {
            }
            return false;
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
