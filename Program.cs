using System;
using System.Security.Cryptography;

namespace TestCriptografia
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string exception = "";
            try
            {
                var password = "Teste123";
                IEncryptPassword hash = new EncryptPassword(SHA512.Create());
                var newPassword = hash.HashGenerate(password);

                var response = hash.CheckHash(password, newPassword) == true ? "Senha verdadeira" : "Senha incorreta";

            }
            catch (NullReferenceException nullReference)
            {
                exception = nullReference.ToString();
            }

            Console.WriteLine(exception.ToString());
        }

    }
}
