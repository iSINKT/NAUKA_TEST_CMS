using System.Security.Cryptography;
using System.Text;

namespace NAUKA_CMS
{

    static public class md5
    {
        static public string GetMD5(string source)
        {
            return ConMD5(GetMd5Hash(source));
        }
        static private string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static private string ConMD5(string MD5)
        {
            string modified = MD5.Insert(8, "-");
            string modified1 = modified.Insert(13, "-");
            string modified2 = modified1.Insert(18, "-");
            string modified3 = modified2.Insert(23, "-");
            return modified3;
        }
    }
    
}
