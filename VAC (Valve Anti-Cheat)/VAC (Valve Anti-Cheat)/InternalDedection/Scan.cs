using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.InternalDedection
{
    public static class Scan
    {
        public static void Do()
        {
            Process CSGO = Process.GetProcessesByName("csgo")[0];
            if (Process.GetProcessesByName("csgo").Length > 0)
            {
                int i = 0;

                foreach (ProcessModule module in CSGO.Modules)
                {

                    string modulename = module.ModuleName;

                    //Console.WriteLine("modulename: " + modulename);

                    if (TrustedModules.list.Any(x => x == modulename))
                    {                        
                        // do some action here if true...
                    }
                    else
                    {
                        i++;
                        Console.WriteLine("invalid dll -> " + modulename + " found in CS:GO modules.");
                    }
                }

                if (i == 0) Console.WriteLine("no injected dll was found");
                else i = 0;


                //rescan yapılacak.
            }
        }
    }
}
