using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC
{
    public static class Offsets
    {
        // GAME STATUS

        public static int clientstate = 6; // 6 = connected
        public static int localplayer = 9370242;
        public static int localplayer_Health = 100;
        public static bool shootsfired = true; // m_iShotsFired returns 1 if local player shooting
    }
}
