using System;
using System.Collections.Generic;

namespace Interfaces
    //DİPNOT: 1 CLASS'I BİRDEN FAZLA INTERFACE ILE IMPLEMENTE EDEBİLİRSİN. YANİ BİRDEN FAZLA INTERFACE KULLANABİLİRSİN
    //ÖR : CLASS Student:IPerson,ISchoolWorker vb. vb.

    //INTERFACE KULLANABİLİYORSAN İNTERFACE KULLAN, KULLANAMIYORSAN INHERITANCE KULLAN.
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();

            //Student student1 = new Student() { 
            //    Age = "19",
            //    Id = 123,
            //    DepartmentName = "MIS",
            //    FirstName = "Yusuf",
            //    LastName = "Çıra",
            //    StudentNumber="1319"};
            //personManager.Add(student1); 

            //CustomerManager customerManager = new CustomerManager();

            //ICustomerDal customerDal = new SqlServerCustomerDal();
            //customerManager.Add(customerDal);
            ////ya yukarıdaki gibi yazıcaksın ya alttaki gibi yazıcaksın. ikisi de aynı şey.
            //customerManager.Add(new SqlServerCustomerDal());

            List<ICustomerDal> customerDals = new List<ICustomerDal>();
            ICustomerDal sqlCustomerDal = new SqlServerCustomerDal();
            customerDals.Add(sqlCustomerDal);
            ICustomerDal oracleCustomerDal = new OracleServerCustomerDal();
            customerDals.Add(oracleCustomerDal);

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
        }
    }

    

    
}
