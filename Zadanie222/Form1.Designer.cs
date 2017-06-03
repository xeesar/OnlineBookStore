namespace Zadanie222
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.logintextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fiotextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.stoimtextbox = new System.Windows.Forms.TextBox();
            this.godizdaniatextbox = new System.Windows.Forms.TextBox();
            this.zhanrtextbox = new System.Windows.Forms.TextBox();
            this.avtornametextbox = new System.Windows.Forms.TextBox();
            this.namebooktextbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.findtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchrich = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.massmakulat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kollbumag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог книг";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuyButton);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.logintextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fiotextbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(267, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 251);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Купить книгу";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(56, 160);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(165, 74);
            this.BuyButton.TabIndex = 6;
            this.BuyButton.Text = "Купить";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(183, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во";
            // 
            // logintextbox
            // 
            this.logintextbox.Location = new System.Drawing.Point(56, 19);
            this.logintextbox.Name = "logintextbox";
            this.logintextbox.Size = new System.Drawing.Size(183, 20);
            this.logintextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // fiotextbox
            // 
            this.fiotextbox.Location = new System.Drawing.Point(56, 55);
            this.fiotextbox.Name = "fiotextbox";
            this.fiotextbox.Size = new System.Drawing.Size(183, 20);
            this.fiotextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Searchbutton);
            this.groupBox1.Controls.Add(this.stoimtextbox);
            this.groupBox1.Controls.Add(this.godizdaniatextbox);
            this.groupBox1.Controls.Add(this.zhanrtextbox);
            this.groupBox1.Controls.Add(this.avtornametextbox);
            this.groupBox1.Controls.Add(this.namebooktextbox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог книг";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(32, 200);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(140, 46);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Просмотр книги";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // stoimtextbox
            // 
            this.stoimtextbox.Location = new System.Drawing.Point(123, 160);
            this.stoimtextbox.Name = "stoimtextbox";
            this.stoimtextbox.Size = new System.Drawing.Size(86, 20);
            this.stoimtextbox.TabIndex = 6;
            // 
            // godizdaniatextbox
            // 
            this.godizdaniatextbox.Location = new System.Drawing.Point(6, 160);
            this.godizdaniatextbox.Name = "godizdaniatextbox";
            this.godizdaniatextbox.Size = new System.Drawing.Size(86, 20);
            this.godizdaniatextbox.TabIndex = 5;
            // 
            // zhanrtextbox
            // 
            this.zhanrtextbox.Location = new System.Drawing.Point(6, 125);
            this.zhanrtextbox.Name = "zhanrtextbox";
            this.zhanrtextbox.Size = new System.Drawing.Size(203, 20);
            this.zhanrtextbox.TabIndex = 4;
            // 
            // avtornametextbox
            // 
            this.avtornametextbox.Location = new System.Drawing.Point(6, 90);
            this.avtornametextbox.Name = "avtornametextbox";
            this.avtornametextbox.Size = new System.Drawing.Size(203, 20);
            this.avtornametextbox.TabIndex = 3;
            // 
            // namebooktextbox
            // 
            this.namebooktextbox.Location = new System.Drawing.Point(6, 55);
            this.namebooktextbox.Name = "namebooktextbox";
            this.namebooktextbox.Size = new System.Drawing.Size(203, 20);
            this.namebooktextbox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.findtextbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Книга";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать последний чек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findtextbox
            // 
            this.findtextbox.Location = new System.Drawing.Point(374, 41);
            this.findtextbox.Name = "findtextbox";
            this.findtextbox.Size = new System.Drawing.Size(151, 20);
            this.findtextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Поиск в тексте";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchrich);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 247);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр книги";
            // 
            // searchrich
            // 
            this.searchrich.Location = new System.Drawing.Point(0, 19);
            this.searchrich.Name = "searchrich";
            this.searchrich.Size = new System.Drawing.Size(341, 222);
            this.searchrich.TabIndex = 0;
            this.searchrich.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(533, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ножка стола";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(196, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 254);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рассчет стопки книг";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Рассчитать стопку";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ввод";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Введите размер ножки стула(см)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(159, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Колличество книг:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 246);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "Случилась беда. Сломалась ножка стула. Но у нас есть книги. Давайте вместо ножки " +
    "поставим стопку из книг. Помоги нам просчитать количество книг для того что бы п" +
    "оставить их вместо ножки.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.massmakulat);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.kollbumag);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(533, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Макулатура";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // massmakulat
            // 
            this.massmakulat.AutoSize = true;
            this.massmakulat.Location = new System.Drawing.Point(489, 10);
            this.massmakulat.Name = "massmakulat";
            this.massmakulat.Size = new System.Drawing.Size(13, 13);
            this.massmakulat.TabIndex = 5;
            this.massmakulat.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Общая масса макулатуры";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сдать макулатуру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(515, 231);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // kollbumag
            // 
            this.kollbumag.AutoSize = true;
            this.kollbumag.Location = new System.Drawing.Point(179, 10);
            this.kollbumag.Name = "kollbumag";
            this.kollbumag.Size = new System.Drawing.Size(13, 13);
            this.kollbumag.TabIndex = 1;
            this.kollbumag.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество бумаги в магазине";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 284);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fiotextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox stoimtextbox;
        private System.Windows.Forms.TextBox godizdaniatextbox;
        private System.Windows.Forms.TextBox zhanrtextbox;
        private System.Windows.Forms.TextBox avtornametextbox;
        private System.Windows.Forms.TextBox namebooktextbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logintextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox findtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox searchrich;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kollbumag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label massmakulat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

