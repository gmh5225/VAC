using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VAC.AimbotDedection
{
    public static class Check
    {
        public static bool Do(Vector3 viewangles)
        {
            if (viewangles.X > 360f) return true;
            if (viewangles.X < -89f) return true;

            if (viewangles.Y > 360f) return true;
            if (viewangles.Y < -180f) return true;

            if (viewangles.Z != 0) return true;

            return false;
        }
    }
}
