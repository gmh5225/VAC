using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAC
{
    public static class RestartAsAdministor
    {
        public static void Start()
        {
            string fileName = Directory.GetCurrentDirectory() + "\\VAC (Valve Anti-Cheat).exe";

            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();

            Environment.Exit(0);
        }
    }
}
