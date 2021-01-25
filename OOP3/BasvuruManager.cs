using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme yaparız.
            //
            creditManager.Hesapla();
            loggerService.Log();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); // dersek her yerde konut kredisi hesaplar. Tüm başvuruları konut kredisine bağımlı hale getiririz.
         }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
