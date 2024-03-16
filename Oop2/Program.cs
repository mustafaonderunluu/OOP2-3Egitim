using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EnginDemiroğ
            GercekMusteri gercekMusteri=new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adı = "Engin";
            gercekMusteri.Soyadı = "Demiroğ";
            gercekMusteri.TcNo = "12345";
            
            //Kodlama.io
            TuzelMusteri tuzelMusteri2=new TuzelMusteri();
             tuzelMusteri2.Id = 2;
            tuzelMusteri2.MusteriNo = "12345";
            tuzelMusteri2.VergiNo = "12855";
            tuzelMusteri2.SirketAdi="Kodlama.io";
            //Bu nedir? //Musteri her 2 sinide tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4= new TuzelMusteri();

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri2);


            //Gerçek-Tüzel Müşteri
            //SOLID (birbirine benziyor diye ınheritance yapma )

        }
    }
}
