using System;

namespace OOP2
    //OOP - Object Oriented Program -C#, Java
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Customer customer1 = new Customer();
             customer1.FirstName = "Yusuf";
             customer1.LastName = "Çıra";
             customer1.CustomerNumber = 123193;
             customer1.Age = "19";
             customer1.FirmName = "??????";
             customer1.TaxNumber = "????";
            */
            //ÜSTTEKİ YANLIŞ KULLANIM ÇÜNKÜ CUSTOMER'I PROP'LARKEN ŞUNU DÜŞÜNMEDİK. ŞİRKETLERİN 1-TÜZEL MÜŞTERİLERİ 2-REAL MÜŞTERİLERİ OLUR.
            //REAL MÜŞTERİNİN FİRMNAME'Sİ OLMAZ VE İKİSİNİ AYNI ANDA VERMEK YANLIŞTIR. O YÜZDEN 2 FARKLI CLASS'TA İNCELEMEK GEREKİYOR.

            //doğrusunu yazıyorum alta
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 123414;
            individualCustomer1.CustomerNumber = "2342";
            individualCustomer1.FirstName = "Yusuf";
            individualCustomer1.LastName = "Çıra";
            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.FirmName = "Turkcell";
            corporateCustomer1.CustomerNumber = "234243";
            corporateCustomer1.Id = 4234243;
            corporateCustomer1.TaxNumber = "4323532432";
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

        }
    }
}
