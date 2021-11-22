using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ArrayListGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Genel Kullanimi

            //10 elemanlı (string) ArrayList içindeki değerleri Z-A olacak şekilde sıralayın.

            ArrayList odevListe = new ArrayList();

            odevListe.Add("Fatih");
            odevListe.Add("Esra");
            odevListe.Add("Ali Mert");
            odevListe.Add("Serdar");
            odevListe.Add("Gamze");
            odevListe.Add("Hakan");
            odevListe.Add("Furkan");
            odevListe.Add("Birol");
            odevListe.Add("Cem");
            odevListe.Add("Yakup");

            // Tüm değerleri A-z çevir

            odevListe.Sort();

            // Sıralamayı terse çevir
            odevListe.Reverse();

            foreach (string item in odevListe)
            {
                Console.WriteLine(item);
            }

            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList a1 = new ArrayList();

            #region Tek Değer Ekleme

            a1.Add("erdem");
            a1.Add(100);
            #endregion

            Capacity = a1.Capacity;
            Count = a1.Count;

            Console.WriteLine(Capacity);
            Console.WriteLine(Count);
            #endregion

            #region Birden Fazla Değer Ekleme İşlemi

            ArrayList A2 = new ArrayList();
            A2.Add("Utku");
            A2.Add("Merve");
            A2.Add("Utkan");
            a1.AddRange(A2);

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #region Koleksiyon içindeki değere ulaşmak

            object o1 = a1[3];
            string s1 = a1[3].ToString();
            //int i1 = (int)a1[1]; kardeşim böyle bir şey mümkün değil.

            a1[3] = "Hamza Atilla";
            Console.WriteLine(a1[3]);
            #endregion

            #endregion

            #region Dizinin mevcut elemanlarını ters olarak sıralama

            a1.Remove(100);
            a1.Reverse();

            //A-Z Sıralama

            a1.Sort();

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Koleksiyonlar Yardımcı Komutları

            if (a1.Contains("Merve"))
            {
                int indexDegeri = a1.IndexOf("Merve");
                a1.RemoveAt(indexDegeri);

            }

            else
            {
                Console.WriteLine("Böyle bir kişi yoktur.");
            }
            #endregion

            bool kontrol1 = a1.Contains("Utkan");
            bool kontrol2 = a1.Contains(900);

            Console.WriteLine("Kontrol1: " + kontrol1 + " Kontrol2: " + kontrol2);

            object[] d1 = a1.ToArray();

            foreach (var item in d1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********************");
            //a1.Clear();

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************");
            a1.Add("Defne");
            //a1.Clear();
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            a1.TrimToSize();

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #region ArrayList koleksiyonu içerisindeki değeri silme
            Console.WriteLine("RemoveAt");
            a1.RemoveAt(3);
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("RemoveRange");
            a1.RemoveRange(2, 2);
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Remove");
            a1.Remove("Hamza Atilla");
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
