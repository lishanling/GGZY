using System;
using GGZY.Core.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DZBHTestProject
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            string priKey =
                @"-----BEGIN PRIVATE KEY-----
MIICdwIBADANBgkqhkiG9w0BAQEFAASCAmEwggJdAgEAAoGBANF8dgR35+XjBs3Y
rnKbDJxF65BUzLppVofvY1+gCg86ta7/H5VtTVq2moy//k0B3rVuA5uk5s6GQeIq
PJOef3oVoAfB5T4cQwNnUdl6iKGAlr8krE7El0HY8xzztbHAJ0MQqMsZJR6w063b
Xf8By7vgflU4soJ5vkrMy4PjhLUdAgMBAAECgYATf5YsjEyVZTA48LYsDKp70TY/
1OTJZQyc0ndZazgEet52T2DNM8NDckOoXiZ5XHcyQ+8qCYtCJdT0DCJfSx1qQHwi
Mx9CKRTTYS+XTutnlzU7uOtxdoOJWXBHzzuHMp2YONqC0/wvelFW3tJgLvW/lPrN
YITD8aeGgVHPGzfSAQJBAPD8hn3HZGgNa7W/nYwgUHv8YSrp9t6N25lgfApYsmH6
GtMXmNT61qPllu4KtRu5Xiox4pHkVdDkBhi4TlumeT0CQQDeiYpcu2zpIW3PU8Qi
qzDYaz2nidbkpt2641Izls9vbwKz98cPqeJigkSUo2djOIiScUe0pgjNTWtyFuJk
filhAkEAh652fqzcEGW2Bj+bkcDD7/r6LnJKZ6XRRXr4e87SqK1rmvyHNSsB3Iew
wdfPfouQxAsQOPopgxJPiG2E2L9TNQJAZsqhXrQ0WntWfa3zqw/oQA9JK1pAKN3r
DahzD+FZb9+XIAoTqOiP6XDCvOW9m9dBPmOU+5y19B8OwmRPrpuYAQJBAJ2IzgBM
UFVLykNomSTXs5vPZC3f13rq/qDcsBLw3CZaYp+p6x9XZsVYr8rmDY3B0bX1r/r5
ascFGUNrY+K6vpU=
-----END PRIVATE KEY-----";
            string xinfeng =
                //"Z3N4wenxSdXZiANQ8IrZ+XX42pJNPwCVrDHHrHAVQbg8KusbwQRPgKF1hOLinDp4pxnGmcAbymWR2CCnyVytABVs3ErRwkDQnCmsbDLugmjjzQRhiXfQo5EPG4omo+Px5swdCVZvt0Es7Maem9nTPk7FbpLImqqnoTyQsabjDaA=";
                //"vfjr4OnfgllSniO53L8Inm1SbtQ7KEVtk/iqUyL0dfs1a+oxMjRTSO3ZwdA38jvaTmN6YfP8PyQd3smj/fYmmx0vMXYEDkBvlTDFpFUymJSmCG3jVUFomJgH3MhAr2EgcUfOnInoqYzovnJlesRadowX5KEkBNFjosMsj5t1jwQ=";
                "BfPljXk7whL9yVAHyfGI7rogHCyYY0/cUFNGsNrJUXpb8Ex9lqn8NYTlfuK/ijtgRWyRV2F/nRrI7OyixSJmynvcD0+LJ2hNnM6AL83yQoaYSU9f/YRahOL3nvi6Ik3sI9Dgcy6czqjlWGWuB3u57tR7lenth43BKYLzH7fay38=";
            string key = Encrypt.RSADecrypt(xinfeng, priKey);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string url = @"C:\Users\86155\Desktop\备案\d27bca3f7a7f4eb29ca54a0e74cb0ff6_DesEncrypted.pdf";
            string outurl = @"C:\Users\86155\Desktop\备案\d27bca3f7a7f4eb29ca54a0e74cb0ff6.pdf";
            string key = "2d82b632b1ab4436a580f799cc961874";
            Encrypt.DESDecryptFile(url, outurl, key);
        }

        [TestMethod]
        public void TestMethod3()
        {
#pragma warning disable CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            Console.WriteLine(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("888820200426094339E7816E811F02D244C9C9E4F82F30DF5F", "MD5"));
#pragma warning restore CS0618 // '“FormsAuthentication.HashPasswordForStoringInConfigFile(string, string)”已过时:“The recommended alternative is to use the Membership APIs, such as Membership.CreateUser. For more information, see http://go.microsoft.com/fwlink/?LinkId=252463.”
            Console.WriteLine(TokenHelper.CreateToken("888820200426094339E7816E811F02D244C9C9E4F82F30DF5F", "12345678"));
        }
    }
}
