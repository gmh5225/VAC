using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VAC.Offsets;

namespace VAC
{
    public static class IsConnected
    {
        public static bool check()
        {
            return localplayer > 0 && clientstate == 6; 
        }
    }
}
