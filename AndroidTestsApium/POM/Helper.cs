using System;

namespace AndroidTestsApium.POM
{
    static public class Helper
    {
        public static string RandomEmailUser()
        {
            string now = DateTime.Now.ToString("ddMMyyyyhhmmss");
            string email = now + "@test.com";
            return email = "narutoSasuke" + now + "@gmail.com";
        }
    }
}
