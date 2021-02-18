using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Şimdi bütün kredilerde kredimanager kullanılacak ama hepsinde farklı faiz oranları farklı değerler vb. olacak. bu durumlarda 
    //class değil interface kullanılıyor.
    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanıyoruz.
    interface IKrediManager
    {
        void Calculate();
        void BirSeyYap();

        

        
    }
}
