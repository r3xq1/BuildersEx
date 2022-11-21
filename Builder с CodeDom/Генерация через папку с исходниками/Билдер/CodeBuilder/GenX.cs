namespace CodeBuilder
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    // Класс для рандомизации строк
    public static class GenX
    {
        const string CHARS = "abcdefghijklmnopqrstuvwxyz1234567890";

        public static string RandomString(int length, bool caseUp)
        {
            StringBuilder res = new();
            using (RNGCryptoServiceProvider rng = new())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(CHARS[(int)(num % (uint)CHARS.Length)]);
                }
            }

            return caseUp ? res?.ToString().ToUpper() : res?.ToString();
        }

        public static int Next(int max)
        {
            byte[] bytes = new byte[4];
            int sse = 0;
            try
            {
                using RNGCryptoServiceProvider rng = new();
                rng.GetBytes(bytes);
                sse = int.MaxValue & BitConverter.ToInt32(bytes, 0);
                return sse % max;
            }
            catch { return sse; }
        }
    }
}