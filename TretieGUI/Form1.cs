using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TretieGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            txtStr.Text = Properties.Settings.Default.str.ToString();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                
                outStr.Text = "Вывод: \n";
                var str = this.txtStr.Text;
                var outmessege = Logic.Couple(str);
                outStr.Text += outmessege;
            Properties.Settings.Default.str = str;
            Properties.Settings.Default.Save();

        }
        private void txtClear_Click(object sender, EventArgs e)
        {
            txtStr.Clear();
        }
        

        
    }
    public class Logic
    {
        public static string Couple(string str)
        {
            string outMessege = "";
            string mre = "";
            if (str != "")//Проверка на ввод
            {
                str += " ";
                if (str[1] == str[0])//Проверка первого элемента
                {
                    mre += str[0];//прибавляем нулевой символ 
                }
                for (int i = 1; i < str.Length - 1; i++)//проход по строке 
                {
                    if ((str[i] == str[i + 1]) | (str[i] == str[i - 1]) && (str[i] != ' '))//Ищем пары игнорируя пробел
                    {
                        mre += str[i];//Прибавляем символ к новой сроке
                        if (str[i] != str[i + 1])//Если подошли к концу блока
                        {
                            mre += " ";//Присваиваем пробел
                        }
                    }
                }
                int sum = 0;
                Console.Write($"{mre}\n");//Выводи получившуюся строку
                mre = mre.TrimEnd(' ');//Удаляем последний символ
                string[] mas = mre.Split(new char[] { ' ' });//Создаем новый массив из строковый блоков 

                foreach (string word in mas)//Цикл подсчета и вывода
                {
                    sum = word.Length;//Количество букв 
                    outMessege += $"{word} - количество одинаковых соседних букв: {sum}\n";
                }
            }
            else
            {
                outMessege = "Пустая строка!";
            }
            return outMessege;
        }
    }
}
