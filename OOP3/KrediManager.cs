using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //eğer tüketici kredisiyse böyle hesapla
        //İhtiyaçsa böyle hesapla tarzı işlemlerin yapıldığı yerdir.
        //Hepsinin Kendisine ait işlemleri vardır.
        //+Böyle durumlarda Base de oluşturduğumuz clası İnterface olarak oluşururuz.
        // eğer ki bu interface kullanılırsa aşağıdaki metodu içermek zorunda.
          void Hesapla();
 
     public  void BiseyYap();


    }
}
