using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+ musteri.Surname+" "+" Eklendi. Diğer alanları da eklemeyi unutmayınız!" );
        }
        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Nolu "+ musteri.Name + " " + musteri.Surname + " Başarıyla silindi");
        }
                    
    }
}
