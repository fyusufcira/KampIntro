using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    //soru:kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz. Starbucks ve nero firması için çalışıyoruz.
    //iki firma da müşterilerini veri tabanına kaydetmek istiyor. Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor.
    //Nero müşterileri kaydederken sadece veri tabanına kaydetmek istiyor. Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001, 29, 05),
                FirstName = "Fatih Yusuf",
                LastName = "Çıra",
                Id = 123,
                NationalityId = "342432"
            }) ;

        }
    }
    
}
