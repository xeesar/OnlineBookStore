using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    //Контроль за сдачей макулатуры
    class Makulatur:Magazin
    {
        private int collmakulatur;
        private int massamakulatur;

        public void Makulaturset(int coll,int mass)
        {
            collmakulatur = coll;
            massamakulatur = mass;
        }

        public int ReturnMass
        {
            get
            {
                return massamakulatur;
            }
        }
    }
}
