using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Menu
    {

        public void yemekMenüsü()
        {
            Console.WriteLine("YEMEKLER");
            Console.WriteLine("1) sandiviçler");
            Console.WriteLine("2) pasta");
            Console.WriteLine("3) cheescake");
            Console.WriteLine("4) cookie");
            Console.WriteLine("5) atistirmaliklar");
            Console.WriteLine("---------------------");
        }

        public void içecekMenüsü()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("İÇECEKLER");
            Console.WriteLine("6) Turk Kahvesi");
            Console.WriteLine("7) Su");
            Console.WriteLine("8) Çay");
            Console.WriteLine("9) Soguk Içecekler");
            Console.WriteLine("10) Filtre Kahve");
            Console.WriteLine("11) Sicak Cikolata");
        }

        public void kredikartı()
        {
            Console.WriteLine("kart bilgilerinizi giriniz...\nÖdemeniz Onaylandı");
            Console.WriteLine("Afiyet Olsun Iyi Gunler");
        }

        public double nakit(double alınanpara, double hesap)
        {
            double paraüstü = alınanpara - hesap;
            return paraüstü;
        }

    }




    public class Fiyatliste
    {

        public double atıştırmalıklar = 18;
        public double cheescake = 35;
        public double cookie = 25;
        public double pasta = 40.5;
        public double sandiviçler = 46.45;

        public double filtekahve = 24.5;
        public double su = 8;
        public double sıcakçikolata = 24.5;
        public double türkkahvesi = 22.5;
        public double çay = 15;
        public double soğukiçecekler = 20;



    }


}





