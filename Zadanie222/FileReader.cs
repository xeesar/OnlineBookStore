using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Zadanie222
{
    class FileReader
    {
        private string text;

        //Получаем текст книги из файла. В данном случае тоже используется инкапсуляция.
        public string getFile(string filename)
        {
            text = File.ReadAllText(filename);
            return text;
        }
    }
}
