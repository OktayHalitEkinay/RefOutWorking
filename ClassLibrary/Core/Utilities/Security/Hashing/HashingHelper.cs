using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out string passwordHash, ref string passwordSalt)
        {
            passwordSalt = password + ":password Salted";
            passwordHash = password + ":password Hashed.";
        }
    }
}
