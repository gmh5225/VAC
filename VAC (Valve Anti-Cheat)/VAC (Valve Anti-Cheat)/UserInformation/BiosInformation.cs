using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.UserInformation
{
    public static class BiosInformation
    {
        public static string Get()
        {
            System.Management.SelectQuery query = new System.Management.SelectQuery(@"Select * from Win32_ComputerSystem");

            //initialize the searcher with the query it is supposed to execute
            using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
            {
                //execute the query
                foreach (System.Management.ManagementObject process in searcher.Get())
                {
                    //system info
                    process.Get();
                    string SystemManufacturer = (string)process["Manufacturer"];
                    string SystemModel = (string)process["Model"];

                    //Console.WriteLine(SystemManufacturer + "\n" + SystemModel);
                    return SystemManufacturer + "\n" + SystemModel;
                }
            }

            return null;
        }
    }
}
