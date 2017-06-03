using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    class Book:Magazin
    {
        private static int _coll;//Колличество книг в магазине. Пример использования инкапсуляции

        public string BookName { get; private set; }
        public string AvtorName { get; private set; }
        public string ZhanrBook { get; private set; }
        public string GodIzdania { get; private set; }
        public double StoimBook { get; private set; }
        public int Ves { get; private set; }
        public int Shirina { get; private set; }
        public string TextBook { get; private set; }

        public Book(string name, string avtor, string zanr, string god, double stoim, int ves, int shirina,string textbook)
        {
            _coll++;

            BookName = name;
            AvtorName = avtor;
            ZhanrBook = zanr;
            GodIzdania = god;
            StoimBook = stoim;
            Ves = ves;
            Shirina = shirina;
            TextBook = textbook;
        }

        /*Пример использования инкапсуляции. В данном примере я разграничил доступ к переменно _coll дабы внешне нельзя
        было изменять данную переменную. Изменение и контроль за изменением этой переменной остается классу Book.*/
        public int Coll
        {
            get
            {
                return _coll;
            }
        }

    }
}
