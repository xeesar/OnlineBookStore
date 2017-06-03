using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie222
{
    //Использование наследования
    class People:Magazin
    {
        protected string username;


        //Использование полиморфизма.
        public virtual string ReturnFIO()
        {
            return "Продовец: ";
        }
    }

    class Prodovec:People
    {
        public static int _coll { get; private set; }
        private string Type = "Prodovec";
        private string FIO;

        public Prodovec(string usn,string fio)
        {
            _coll++;
            username = usn;
            FIO = fio;
        }
        //Использование полиморфизма. Метод один но используется по разному.
        //В данном случае метод был дополнен. 
        public override string ReturnFIO()
        {
            return base.ReturnFIO() + FIO;
        }
    }

    class Klient:People
    {
        public static int _collklient { get; private set; }
        private string Type = "User";
        private string FIO;

        public Klient(string usn,string fio)
        {
            _collklient++;
            username = usn;
            FIO = fio;
        }

        //В данном случае используется полиморфизм. Виртуальный метод родительского класса был переопределен.
        //Пример использования полиморфизма и инкапсуляции.
        public override string ReturnFIO()
        {
            return FIO;
        }

    }
}
