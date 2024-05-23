
using System.Net;
using System.Text.RegularExpressions;

namespace prac7
{
    
    public static class Validation
    {
        public static bool IsValidUsername(string username)
        {
            
            return !string.IsNullOrEmpty(username) && Regex.IsMatch(username, @"^\w+$");
        }

        public static bool IsValidIP(string ip)
        {
          
            IPAddress address;
            return IPAddress.TryParse(ip, out address);
        }
    }
}
