using System;

namespace scho_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: {message}.");

            int shift = 1;
            while (shift <= 10)
            {
                Cipher cipher;
                cipher = new Cipher(shift);
                
                string decrypted;
                decrypted = cipher.Decrypt(message);
                Console.WriteLine($"Shift {shift}: {decrypted}");

                shift += 1;
            }
            
        }
    }
}
