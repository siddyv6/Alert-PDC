using System.Security.Cryptography;
using System;
using System.Linq;
using BCrypt.Net;


namespace Alarm
{
    public static class Encryption
{
        //        //Source https://codereview.stackexchange.com/questions/96494/user-password-encryption-in-c
        //private const int SaltByteSize = 24;
        //private const int HashByteSize = 24;
        //private const int HasingIterationsCount = 10101;

        //public static byte[] ComputePasswordHash(String password, byte[] salt)
        //{
        //    Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
        //    hashGenerator.IterationCount = HasingIterationsCount;
        //    return hashGenerator.GetBytes(HashByteSize);
        //}

        //public static byte[] GenerateSalt()
        //{
        //    RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();
        //    byte[] salt = new byte[SaltByteSize];
        //    saltGenerator.GetBytes(salt);
        //    return salt;
        //}

        //public static bool VerifyPassword(String password, byte[] passwordSalt, byte[] passwordHash)
        //{
        //    byte[] computedHash = ComputePasswordHash(password, passwordSalt);
        //    return ComputePasswordHash(password, passwordSalt).SequenceEqual(computedHash);
        //    // return AreHashesEqual(computedHash, passwordHash);
        //}

        ////Length constant verification - prevents timing attack
        //private static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)
        //{ 
        //    int minHashLenght = firstHash.Length <= secondHash.Length ? firstHash.Length : secondHash.Length;
        //    var xor = firstHash.Length ^ secondHash.Length;
        //    for (int i = 0; i < minHashLenght; i++)
        //        xor |= firstHash[i] ^ secondHash[i];
        //    return 0 == xor;
        //}


        // source: https://cmatskas.com/a-simple-net-password-hashing-implementation-using-bcrypt/
     
            public static string GetRandomSalt()
            {
                return BCrypt.Net.BCrypt.GenerateSalt(12);
            }

            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password, 10);
        }

            public static bool ValidatePassword(string password, string correctHash)
            {
           // string str = "asdf";
           // string pass = BCrypt.Net.BCrypt.HashPassword(password, 10);
         //   string pass2 = BCrypt.Net.BCrypt.HashPassword(str, 10);

            return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
        
    }   
}