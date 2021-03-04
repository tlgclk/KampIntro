using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ////İnterface ler de diğer class ların referans numarasını tutabilir
            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            TasitKrediManager tasitKrediManager = new TasitKrediManager();           
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {esnafKredisiManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
