﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class İhtiyaçKrediManager : IKrediManager
    {
      void IKrediManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

    void IKrediManager.Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");

        }
    }
}
