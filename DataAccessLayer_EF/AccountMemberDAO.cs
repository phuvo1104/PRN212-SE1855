using DataAccessLayer_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_EF
{
    public class AccountMemberDAO
    {
        MyStoreContext context = new MyStoreContext();
        public AccountMember GetAccountMemberByEmailAndPassword(string email, string password)
        {
            return context.AccountMembers.FirstOrDefault(am => am.EmailAddress == email && am.MemberPassword == password);
        }
    }
}
