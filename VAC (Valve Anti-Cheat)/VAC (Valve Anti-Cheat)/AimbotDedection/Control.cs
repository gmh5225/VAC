using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VAC.AimbotDedection.Vectors;

namespace VAC.AimbotDedection
{
    public static class Control
    {
        public static void Do()
        {
            restart:

            if (!IsGameOpened.check())
            {
                Thread.Sleep(2500);
                goto restart;
            }
            // if csgo started;


            // while connected
            while (Offsets.clientstate == 6) 
            {
                new Thread(() =>
                {
                    Vectors.rnd(); // initalize random to add viewangles
                }).Start();

                Thread.Sleep(50); // 50 is so slowly..


                // if local player not connected, jump end.
                if (!IsConnected.check())
                {
                    Clear(); continue;
                }

                // if local player is ded, jump end.
                if (Offsets.localplayer_Health == 0)
                {
                    Clear(); continue;
                }

                //player moving is basicly changes viewangles
                AimAngles.X += PlayerMoving.X;
                AimAngles.Y += PlayerMoving.Y;
                AimAngles.Z += PlayerMoving.Z;


                //this is normalized (true) viewangles
                Vector3 CurrentViewAngles = Math.normalize(AimAngles);
                //Console.WriteLine("x: " + CurrentViewAngles.X);
                //Console.WriteLine("y: " + CurrentViewAngles.Y);
                //Console.WriteLine("y: " + CurrentViewAngles.Z);

                

                // control aim angles
                // if some cheats changing viewangles with broken aimbot math, it be should return true.
                // So will be dedected:
                if (Check.Do(CurrentViewAngles)) // you can test with not normalized AimAngles too :)
                {
                    MessageBox.Show("Rejecting invalid value.\nX: " + CurrentViewAngles.X + " Y: " + CurrentViewAngles.Y + " Z: " + CurrentViewAngles.Z);
                }     
            }
        }
    }
}
