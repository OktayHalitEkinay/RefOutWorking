using ClassLibrary.Core.Utilities.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class AuthManager
    {
        public string Register()
        {
            string passwordHash, passwordSalt="saltsaltsalt",password="secretsecret";
            HashingHelper.CreatePasswordHash(password,out passwordHash,ref passwordSalt);
            return passwordHash;
        }
    }
}
