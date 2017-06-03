using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    class Magazin
    {
        public static string MagazinName { get; private set; }
        public static string MagazinAdress { get; private set; }

        public Magazin()
        {
            MagazinName = "OZ.by";
            MagazinAdress = "Сурганова 15";
        }

    }
}
