using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager(); //ICreditManager yerine -IhtiyacKrediManager da yazılabilirdi.
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, new FileLoggerService()); // burada da newlenebilir.

            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
