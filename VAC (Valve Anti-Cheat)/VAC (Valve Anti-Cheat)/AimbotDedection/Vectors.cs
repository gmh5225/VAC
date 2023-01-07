using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VAC.AimbotDedection
{
    public static class Vectors
    {
        public static Vector3 AimAngles = new Vector3();
        public static Vector3 PlayerMoving = new Vector3();

        public static void Clear()
        {
            AimAngles.X = 0;
            AimAngles.Y = 0;
            AimAngles.Z = 0;
        }

        public static void rnd()
        {
            Random rand = new Random();
            double min = 1;
            double max = 10;
            double range = max - min;
            for (int i = 0; i < 10; i++)
            {
                double sample = rand.NextDouble();
                double scaled = (sample * range) + min;
                float x = (float)scaled;
                float y = (float)((float)scaled * 0.7);
                float z = 0;

                PlayerMoving.X = x * 2.5f;
                PlayerMoving.Y = y * 1.4f;
                PlayerMoving.Z = z;

                // test move
                //Console.WriteLine("PlayerMoving.X: " + PlayerMoving.X);
                //Console.WriteLine("PlayerMoving.Y: " + PlayerMoving.Y);
                //Console.WriteLine("PlayerMoving.Z: " + PlayerMoving.Z);
            }
        }
    }
}
