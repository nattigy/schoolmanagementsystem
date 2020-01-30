using System.Security.Cryptography;
using System.Text;

namespace sms.Utils
{
    public class Encrypt
    {
        public static string GetShaData(string data)
        {
            var sha = SHA1.Create();
            var hashData = sha.ComputeHash(Encoding.Default.GetBytes(data));
            var returnValue = new StringBuilder();
            int i;
            for (i = 0; i < hashData.Length - 1; i++) returnValue.Append(hashData[i].ToString());

            return returnValue.ToString();
        }
    }
}