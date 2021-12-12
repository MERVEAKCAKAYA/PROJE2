using System;
using System.Collections.Generic;
namespace ToDoUygulama
{
     public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyuluk Boyut { get; set; }

        public enum Buyuluk
        {
            XS,
            S,
            M,
            L,
            XL
        } 

        public Kart(string baslik,string icerik,string atananKisi,Buyuluk boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Boyut = boyut;
        }


    }
    class Islemler
    {
        
        Dictionary<int, string> kisiler = new Dictionary<int, string>();


        List<Kart> TODO = new List<Kart>();
        List<Kart> INPROGRESS = new List<Kart>();
        List<Kart> DONE = new List<Kart>();

        public Islemler()
        {
            kisiler.Add(0, "Beytullah KALAY");
            kisiler.Add(1, "Kutup YAZAR");
            kisiler.Add(2, "Okan AYDUZ");
            kisiler.Add(3, "Dervis AKKOC");
            kisiler.Add(4, "Refik ACA");

            TODO.Add(new Kart("Temizlik", "Yerleri Supur", "Beytullah KALAY",Kart.Buyuluk.M));
            INPROGRESS.Add(new Kart("Temizlik", "Camlari Sil", "Okan AYDUZ",Kart.Buyuluk.S));
            DONE.Add(new Kart("Spor", "2 Km Kos", "Dervis AKKOC",Kart.Buyuluk.L));
            DONE.Add(new Kart("Ev", "Alisveris Yap", "Refik ACA",Kart.Buyuluk.XL));
            INPROGRESS.Add(new Kart("Temizlik", "Toz Al", "Kutup YAZAR",Kart.Buyuluk.XS));
        }    
        
        public void Yazi()
        {
            Console.WriteLine("Lutfen yapmak istediginiz islemi secin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Kart Eklemek");
            Console.WriteLine("(2) Kart Guncelle");
            Console.WriteLine("(3) Kart Sil");
            Console.WriteLine("(4) Kart Tasi");
            Console.WriteLine("(5) Board Listelemek");
            Console.WriteLine("(6) Cikis");
        }
        public void BoardListele()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line");
            Console.WriteLine("*****************************");

            foreach (var kart in TODO)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*****************************");

            foreach (var kart in INPROGRESS)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("DONE Line");
            Console.WriteLine("*****************************");

            foreach (var kart in DONE)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
            while (true)
            {
                islemler.Yazi();
                int input=Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1: // Kart Ekle
                        
                        break;
                    case 2: // Kart Guncelle
                        
                        break;
                    case 3: // Kart Sil
                        
                        break;
                    case 4: // Kart Tasi
                        
                        break;
                    case 5: // Board Listele
                        islemler.BoardListele();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Boyle bir secim yok. Cikis yapiliyor.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }

}
