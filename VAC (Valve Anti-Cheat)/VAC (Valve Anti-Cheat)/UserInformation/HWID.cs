using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.UserInformation
{
    public static class HWID
    {
        public static string User()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }
        public static string Owner()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Owner.Value;
        }
    }
}
