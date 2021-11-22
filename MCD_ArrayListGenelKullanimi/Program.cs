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

            


            #endregion
            Console.ReadLine();
        }
    }
}
