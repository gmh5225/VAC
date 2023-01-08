using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VAC.AimbotDedection
{
    public static class Math
    {
        public static Vector3 normalize(Vector3 delta)
        {
            // X
            if (delta.X > 89.0f && delta.X <= 180.0f)
                delta.X = 89.0f;
            while (delta.X > 180.0f)
                delta.X -= 360.0f;
            while (delta.X < -89.0f)
                delta.X = -89.0f;

            // Y
            while (delta.Y > 180.0f)
                delta.Y -= 360.0f;
            while (delta.Y < -180.0f)
                delta.Y += 360.0f;

            // Z
            delta.Z = 0;

            return delta;
        }
    }
}
