using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Accounts.Entities.Accounts
{
    public enum AuthenticationSource
    {
        CUSTOM = 1, 
        AZURE, 
        AWS, 
        GMAIL
    }
}
