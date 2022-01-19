using System;

namespace scho_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is: '{encrypted}'");
            
            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");
        }
    }
}
