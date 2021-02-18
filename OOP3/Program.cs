using System;
using System.Collections.Generic;

namespace OOP3
    //OOP-OBJECT ORIENTED PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Calculate();
            ////BUNUN YERİNE alttakini de yazabilirsin
            //IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Calculate();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Calculate();
            ////BUNUN YERİNE alttakini de yazabilirsin
            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Calculate();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Calculate();
            ////BUNUN YERİNE alttakini de yazabilirsin
            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Calculate();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService eMailLoggerService = new EMailLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService,eMailLoggerService,fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggers);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
