using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu Menü1 = new Menu();
            Fiyatliste YemekİçecekListe = new Fiyatliste();
            double[] toplamücret = new double[9];


            Console.WriteLine("Deniz Cafeye Hoş Geldiniz");
            Console.WriteLine("-------------------------");
            Console.WriteLine("MENÜYÜ GÖRMEK İÇİN 'M' tuşuna basiniz");
            string seçim = Console.ReadLine().ToUpper();
            Console.Clear();
            if (seçim == "M")
            {
                Menü1.yemekMenüsü();
                Menü1.içecekMenüsü();
            }



        ürünler:
            Console.WriteLine("-------------------------");
            Console.WriteLine("Lutfen urun seciniz");
            seçim = Console.ReadLine();



            switch (seçim)
            {
                case "1":
                    toplamücret[0] = YemekİçecekListe.sandiviçler;

                    break;
                case "2":

                    toplamücret[1] = YemekİçecekListe.pasta;
                    break;
                case "3":

                    toplamücret[2] = YemekİçecekListe.cheescake;
                    break;
                case "4":

                    toplamücret[3] = YemekİçecekListe.cookie;
                    break;
                case "5":

                    toplamücret[4] = YemekİçecekListe.atıştırmalıklar;
                    break;
                case "6":

                    toplamücret[5] = YemekİçecekListe.türkkahvesi;
                    break;
                case "7":

                    toplamücret[6] = YemekİçecekListe.su;
                    break;
                case "8":

                    toplamücret[7] = YemekİçecekListe.çay;
                    break;
                case "9":

                    toplamücret[8] = YemekİçecekListe.soğukiçecekler;
                    break;
                case "10":

                    toplamücret[9] = YemekİçecekListe.filtekahve;
                    break;
                case "11":

                    toplamücret[10] = YemekİçecekListe.sıcakçikolata;
                    break;

                default:
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR NUMARA GİRİN!!!");
                    break;




            }

            Console.WriteLine("yeni urun eklemek ister misiniz?\nEvet ise 'E' Hayir ise 'H' seçiniz...");

            seçim = Console.ReadLine().ToUpper();

            if (seçim == "E")
            {
                goto ürünler;
            }
            else
            {
                double toplam = 0;
                for (int i = 0; i < toplamücret.Length; i++)
                {
                    toplam += toplamücret[i];
                }

                Console.Clear();
                Console.WriteLine(toplam + "tl");

                Console.WriteLine("Odeme Turunuzu seciniz\n1)Kredi Kartı\n2)Nakit");
                seçim = Console.ReadLine();

                Console.Clear();

                if (seçim == "1")
                {
                    Menü1.kredikartı();
                }
                else if (seçim == "2")
                {
                    Console.WriteLine("nakit miktarini giriniz");
                    double alınanpara = double.Parse(Console.ReadLine());
                    double paraüstü = Menü1.nakit(alınanpara, toplam);
                    Console.WriteLine("para ustunuz=" + paraüstü + "tl");
                    Console.WriteLine("Afiyet Olsun iyi Gunler...");
                }


            }


            Console.ReadKey();


        }
    }
}




