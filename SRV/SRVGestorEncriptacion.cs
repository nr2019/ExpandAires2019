using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV
{
           public class SRVGestorEncriptacion
    {
        public string EncriptarConMD5(string ValorEncriptar)
        {
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(ValorEncriptar));
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), "-", "");
        }
    }
}
 