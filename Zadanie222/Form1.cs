using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie222
{
    public partial class Form1 : Form
    {
        Nozka nozka = new Nozka();
        Makulatur makulat = new Makulatur();
        List<Book> booklist = new List<Book>();
        List<Prodovec> prodlist = new List<Prodovec>();
        List<Klient> klientlist = new List<Klient>();
        List<Chek> cheklist = new List<Chek>();

        private int bookindex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Добовление книг в книжный магазин
            booklist.Add(new Book("Алые паруса", "Евтух В.С." ,"Фантастика", "2005", 3.15,300,8,new FileReader().getFile("1.txt")));//Получаем файл текста книги.
            booklist.Add(new Book("С# - это так просто!", "Троелсон Э.", "Обучающая литература", "2010", 5.00,210,10, new FileReader().getFile("2.txt")));
            booklist.Add(new Book("Хроники Нарнии. Племянник Чародея ", "Клайв С.Л.", "Фантастика", "2016", 24.99,300,13, new FileReader().getFile("3.txt")));
            booklist.Add(new Book("Варкрафт", "Кристи Г.", "Фантастика", "2016", 10.95,320,8, new FileReader().getFile("4.txt")));
            booklist.Add(new Book("Unity в действии. Мультиплатформенная разработка на C# ", "Евтух В.С.", "Языки программирования", "2016", 40.17, 420, 7, new FileReader().getFile("5.txt")));

            //Указываем колличество книг в магазине
            label8.Text = booklist.Count.ToString();

            //Добавление книг в каталог
            foreach (var a in booklist)
            {
                comboBox1.Items.Add(a.BookName);
            }

            //Добавляем продовца в магазин
            prodlist.Add(new Prodovec("prodovec","Филимонов А.С."));
        }

        //Метод отвечающий за вывод информации о книге при выборе ее названия в каталоге
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookindex = 0;
            foreach(var a in booklist)
            {
                bookindex++;
                if (a.BookName == comboBox1.Text)
                {
                    namebooktextbox.Text = a.BookName;
                    avtornametextbox.Text = a.AvtorName;
                    zhanrtextbox.Text = a.ZhanrBook;
                    godizdaniatextbox.Text = a.GodIzdania;
                    stoimtextbox.Text = a.StoimBook.ToString();
                    break;
                }
            }
        }

        //Отвечает за вывод текста книги для его просмотра или поиска информации
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            searchrich.Text = booklist[bookindex - 1].TextBook;
        }

        //Поиск информации в тексте
        private void button1_Click(object sender, EventArgs e)
        {
            if(findtextbox.Text == "" || findtextbox.Text == " ")
            {
                MessageBox.Show("Поле ввода информации для поиска не должно быть пустым.", "Ошибка поиска",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int startPos = 0;//Находим стартовую позицию слова, текста или букву которую мы ишем.
                startPos = searchrich.Text.IndexOf(findtextbox.Text);
                if (startPos < 0)
                {
                    MessageBox.Show("Слово: " + findtextbox.Text + " не найдено", "Поиск слова", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    searchrich.Select(startPos, findtextbox.Text.Length);
                    searchrich.ScrollToCaret();
                    searchrich.Focus();
                }
            }
        }

        //Реализация покупки книг.
        private void BuyButton_Click(object sender, EventArgs e)
        {
            klientlist.Add(new Klient(logintextbox.Text,fiotextbox.Text));
            cheklist.Add(new Chek(Magazin.MagazinName, Magazin.MagazinAdress, booklist[bookindex - 1].BookName, (int)numericUpDown1.Value, prodlist[Prodovec._coll - 1].ReturnFIO(), klientlist[Klient._collklient - 1].ReturnFIO(), DateTime.Now.ToShortDateString()));
            MessageBox.Show("Спасибо за покупки книги: " + booklist[bookindex - 1].BookName,"Покупка выполнена!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            kollbumag.Text = Chek._coolchek.ToString();
        }

        //Вывод чека в на экран.
        private void button2_Click(object sender, EventArgs e)
        {
            searchrich.Text = String.Format(" Имя магазина: {0} \n Адресс магазина: {1} \n Имя книги: {2} \n Колличество книг: {3} \n {4} \n Покупатель: {5} \n Дата покупки: {6}",cheklist[Chek._coolchek-1].NameMagaz, cheklist[Chek._coolchek-1].AdressMagaz, cheklist[Chek._coolchek-1].NameBook, cheklist[Chek._coolchek-1].KoolBooks, cheklist[Chek._coolchek-1].Prodavec, cheklist[Chek._coolchek-1].Klient, cheklist[Chek._coolchek-1].Date);
        }

        //Сдача макулатуры
        private void button3_Click(object sender, EventArgs e)
        {
            makulat.Makulaturset(Convert.ToInt32(kollbumag.Text),Convert.ToInt32(kollbumag.Text)*200);//200 - масса в граммах одного чека.
            cheklist.RemoveRange(0,cheklist.Count);
            kollbumag.Text = "0";
            massmakulat.Text = makulat.ReturnMass.ToString();
        }

        //Пользователь вводит размер ножки(в см)
        private void button4_Click(object sender, EventArgs e)
        {
            nozka.GetHeightToNizka(Convert.ToInt32(textBox1.Text));
        }

        //Реализация поиска количества книг, необходимых для использования вместо ножки.
        private void button5_Click(object sender, EventArgs e)
        {
            int height = 0;
            int count = 0;
            bool rezult = false;
            foreach(var a in booklist)
            {
                height += a.Shirina;
                count++;
                if (nozka.Equal(height))
                {
                    rezult = true;
                    break;
                }
            }
            if (!rezult) MessageBox.Show("Наших книг не достаточно что бы сделать из них стопку по размеру ножки стола.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                if (nozka.ostatki == 0)
                {
                    MessageBox.Show("Колличество книг, необходимых для стопки вместо ножки стола: " + count.ToString(), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else MessageBox.Show("Колличество книг, необходимых для стопки вместо ножки стола: " + count.ToString() + ". Но размер книг больше чем ножка стола. Размер книг больше чем ножка стола на: " + nozka.ostatki.ToString() + "см.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
