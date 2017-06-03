using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    class Nozka:Magazin
    {
        public int height { get; private set; }
        public int ostatki { get; private set; }
        //Получаем размер длину ножки. 
        public void GetHeightToNizka(int height)
        {
            this.height = height;
        }

        //Сравнивает ширину книг с длиной ножки.
        public bool Equal(int bookwidth)
        {
            if (height <= bookwidth)
            {
                ostatki = bookwidth - height;
                return true;
            }
            return false;
        }
    }
}
