using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    class Chek:Magazin //Формировани чека
    {
        public static int _coolchek { get; private set; }

        public string NameMagaz { get; private set; }
        public string AdressMagaz { get; private set; }
        public string NameBook { get; private set; }
        public int KoolBooks { get; private set; }
        public string Prodavec { get; private set; }
        public string Klient { get; private set; }
        public string Date { get; private set; }

        public Chek(string namemag,string adress,string namebook,int koolbook,string prodovec,string klient,string date)
        {
            _coolchek++;

            NameMagaz = namemag;
            AdressMagaz = adress;
            NameBook = namebook;
            KoolBooks = koolbook;
            Prodavec = prodovec;
            Klient = klient;
            Date = date;
        }
    }
}
