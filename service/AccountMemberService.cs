using DataAccessLayer_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services_EF
{
    internal class AccountMemberService : IAccountMemberService
    {
        public AccountMember GetAccountMemberByEmailAndPassword(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
