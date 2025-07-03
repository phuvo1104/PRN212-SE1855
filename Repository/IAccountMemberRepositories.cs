using DataAccessLayer_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_EF
{
    internal interface IAccountMemberRepositories
    {
        public AccountMember GetAccountMemberByEmailAndPassword(string email, string password);
    }
}
