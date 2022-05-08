using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestCriptografia
{
    public class EncryptPassword : IEncryptPassword
    {
        private HashAlgorithm _hashAlgorithm;
        public EncryptPassword(HashAlgorithm hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;
        }

        public string HashGenerate(string password)
        {
            var codificationValue = Encoding.UTF8.GetBytes(password);
            var HashPassword = _hashAlgorithm.ComputeHash(codificationValue);
            var codeHashPassword = new StringBuilder();

            foreach (var code in HashPassword)
                codeHashPassword.Append(code.ToString("X2"));

            return codeHashPassword.ToString();
        }

        public bool CheckHash(string enteredPassword, string passwordRegistered)
        {
            if (string.IsNullOrEmpty(enteredPassword))
                throw new NullReferenceException("Campo vazio");

            enteredPassword = HashGenerate(enteredPassword);

            return enteredPassword == passwordRegistered;

        }
    }
}

//1094923214282232008216817418121816782321692153811392268978911701082218920931199695315216924425420116820913710824568184784320641087118219811922617514522023416495236129141
