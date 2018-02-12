using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Uygulama
{
    //Kullanıcı arayüzü değil ama kod arayüzü olarak düşünebiliriz.
    //İsimlendirirken ilk harfi I olarak yazılır.(Şart değil ayırt edebilmek için)
    //Abstract class lara çok benzer
    //interface lerde field oluşturulamaz.
    //Var olan bir interface'i bir class'a eklediğimizde sözleşmesini imzalayıp imzalamadığımızı sorar.
    //Interface içerisinde var olan tüm method ve propertyleri class içerisine aktarmak zorundayız.
    //Interface lerde yazdıgımız tüm methodlar ve property ler kendiliğinden public olarak gelir.
    //Interface lerden miras(inherit) alınmaz, uyarlanır(implementation)
    //Bir class'a sadece bir class dan miras alınabiliyorken birden fazla interface implement edilebilir.
    //Interface tanımlanırken içerisinde tanımlanan öğeler için herhangi bir erişim belirleyicisi kullanılmaz.



    interface IVehicle
    {
        void Start();   //metodun içersini doldurmamızı beklemez
        void Stop();
        void Horn();
        void Accelerate();
        void Brake();


    }
}
