using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
           IKrediManager ihkredi= new İhtiyaçKrediManager();
            IKrediManager kntkredi = new KonutKrediMnager();  
            IKrediManager tstkredi = new TaşıtKrediManager();
       
         BasvuruManager basvuru = new BasvuruManager();
            //basvuru.BasvuruYap(ihkredi);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihkredi };
            basvuru.KrediOnBilgilendirmesiYap(krediler);

            
        }
    }
}
