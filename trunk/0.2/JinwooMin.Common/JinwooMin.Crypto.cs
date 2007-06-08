using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace JinwooMin.Cryptography
{
	public class DESCrypto
	{
        #region Password En/Decryption

        // ref.: http://www.dotnetspider.com/qa/Question741.aspx

        public static string EncryptPasswd(string strPasswd, string strKey, byte[] byIV)
        {
            if (strPasswd == null)
            {
                return null;
            }

            byte[] byKey = System.Text.Encoding.UTF8.GetBytes(strKey);
            byte[] byPasswd = System.Text.Encoding.UTF8.GetBytes(strPasswd);

            DESCryptoServiceProvider sp = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sp.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);
            cs.Write(byPasswd, 0, byPasswd.Length);
            cs.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string DecryptPasswd(string strPasswd, string strKey, byte[] byIV)
        {
            if (strPasswd == null)
            {
                return null;
            }

            byte[] byKey = System.Text.Encoding.UTF8.GetBytes(strKey);
            byte[] bySrc = Convert.FromBase64String(strPasswd);

            DESCryptoServiceProvider sp = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sp.CreateDecryptor(byKey, byIV), CryptoStreamMode.Write);
            cs.Write(bySrc, 0, bySrc.Length);
            cs.FlushFinalBlock();

            return System.Text.Encoding.UTF8.GetString(ms.ToArray());
        }


        #endregion
    }
}
