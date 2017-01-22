using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.HelperClasses
{
    public class GetHashCode
    {
        #region GetHash
        public string GetHash(string password, string salt)
        {
            byte[] saltBytes = Encoding.ASCII.GetBytes(salt);


            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(password);
            byte[] plainDataAndSalt = new byte[plainData.Length + saltBytes.Length];

            for (int x = 0; x < plainData.Length; x++)
            {
                plainDataAndSalt[x] = plainData[x];
            }
            for (int n = 0; n < saltBytes.Length; n++)
            {
                plainDataAndSalt[plainData.Length + n] = saltBytes[n];
            }
            byte[] hashValue = null;

            SHA256Managed sha = new SHA256Managed();
            hashValue = sha.ComputeHash(plainDataAndSalt);
            sha.Dispose();

            byte[] result = new byte[hashValue.Length + saltBytes.Length];

            for (int x = 0; x < hashValue.Length; x++)
            {
                result[x] = hashValue[x];
            }
            for (int n = 0; n < saltBytes.Length; n++)
            {
                result[hashValue.Length + n] = saltBytes[n];
            }

            return Convert.ToBase64String(result);
        }
        #endregion
    }
}
