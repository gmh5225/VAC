using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace VAC.UserInformation
{
    public static class BiosVersion
    {
        public static string Get()
        {
            System.Management.ManagementObjectSearcher searcher1 = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            System.Management.ManagementObjectCollection collection = searcher1.Get();

            foreach (ManagementObject obj in collection)
            {
                if (((string[])obj["BIOSVersion"]).Length > 1)
                {
                    //Console.WriteLine("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0] + " - " + ((string[])obj["BIOSVersion"])[1]);
                    return ("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0] + " - " + ((string[])obj["BIOSVersion"])[1]);
                }
                else
                {
                    //Console.WriteLine("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0]);
                    return ("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0]);   
                }
            }

            return null;
        }
    }
}
