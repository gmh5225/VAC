using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static VAC.ConsoleHelper;

namespace VAC
{
    public static class ScanProcess
    {
        public static void Do()
        {
            for (; ; ) // while (true) da olur
            {

                // csgo kapalı ise atlar
                if (!IsGameOpened.check())
                {
                    Warning("CS:GO not opened.");
                    Thread.Sleep(2500);

                    continue;
                }


                // bu yöntemin içindeki goto rescan sayesine döngü tamamlanmadan düzgün çalışır.
                ProcessList.ScanAll();

            }
        }
    }
}
