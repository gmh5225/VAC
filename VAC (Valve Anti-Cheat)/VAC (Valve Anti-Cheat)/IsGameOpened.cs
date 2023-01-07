using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC
{
    public static class IsGameOpened
    {
        public static bool check()
        {
            Process[] csgo = Process.GetProcessesByName("csgo");
            if (csgo.Length == 0) return false;

            return true;
        }
    }
}
