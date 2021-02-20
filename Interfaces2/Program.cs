using System;

namespace Interfaces2
    //interface newlenemez.
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();
            IPersonManager customerManager = new CustomerManager();
            projectManager.Add(customerManager);
            IPersonManager employeeManager = new EmployeeManager();
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
        }
    }

    //class PersonManager
    //{
    //    public void Add() { Console.WriteLine("Added."); }
    //}
    //                  ÜSTTEKİNİ İNTERFACEYE BÖYLE ÇEVİRİYORUZ. ÇEVİRMELİYİZ DE.   INHERITANCE'DA KOD HER YERDE ORTAK. YANİ ADD(){} DİYOSUN YA
    //                  SÜSLÜ PARANTEZİN İÇİNDEKİ ŞEY HER YERDE TAM OLARAK AYNI YAZILIYOR DEMEK. INTERFACEDEYSE İÇİNİ KENDİN YAZIYOUSN NE YAZMAK
    //                  İSTERSEN.

    interface IPersonManager
    {
        //unimplemented kodları.
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //çalışan ekleme kodları
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager) {
            personManager.Add();
        

        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }




}
