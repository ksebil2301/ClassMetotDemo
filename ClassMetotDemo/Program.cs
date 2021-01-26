using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.Id = 1;
            M1.Name = "Gizem";
            M1.Surname = "Özmen";
            M1.Phone = 1988;
            M1.Mail = "gizem.ozmen@gmail.com";
            M1.Position = "Makina Mühendisi";

            Musteri M2 = new Musteri();
            M2.Id = 2;
            M2.Name = "Kübra";
            M2.Surname = "Eraydın";
            M2.Phone = 4013;
            M2.Mail = "kubra.erydn@gmail.com";
            M2.Position = "Elektrik- elektronik Mühendisi";

            Musteri M3 = new Musteri();
            M3.Id = 3;
            M3.Name = "Yasemin";
            M3.Surname = "Özbayrak";
            M3.Phone = 2749;
            M3.Mail = "yasmin.ozbyrk@gmail.com";
            M3.Position = "Maden Mühendisi";

            Musteri M4 = new Musteri();
            M4.Id = 4;
            M4.Name = "Armağan";
            M4.Surname = "Yılmaz";
            M4.Phone = 5055;
            M4.Mail = "armi.yilmz@gmail.com";
            M4.Position = "Bilgisayar Mühendisi";
            Musteri[] musteriler = new Musteri[] { M1, M2, M3, M4 };
            
            {
                foreach (var cust in musteriler)
                {
                    Console.WriteLine(cust.Id + "Nolu müşteri : " + cust.Name + " " + cust.Surname);
                }
                Console.WriteLine("--------------------");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(M3);
            musteriManager.Del(M4);

        }
        
    }
}
