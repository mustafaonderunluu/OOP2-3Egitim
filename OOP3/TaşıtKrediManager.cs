using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class TaşıtKrediManager : IKrediManager
    {
        void IKrediManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void IKrediManager.Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
