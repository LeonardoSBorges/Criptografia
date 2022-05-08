using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCriptografia
{
    public interface IEncryptPassword
    {
        string HashGenerate(string password);
        bool CheckHash(string enteredPassword, string passwordRegistered);
    }
}
