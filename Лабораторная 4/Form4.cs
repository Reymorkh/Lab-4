using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_4
{
    public partial class Form4 : Form
    {
        public int arrayLength = 0, countdown = 0;
        DialogResult dialogResult;
        public void ArrayPrinter(int arrayLengthLocal, int x)
        {
            MainWindow.Text = "Вам осталось " + (Form1.arrayLength - x) + " элементов. Вид массива прямо сейчас:" + Environment.NewLine;

            if (arrayLength != 0 || arrayLengthLocal != 0)
            {
                for (int i = 0; i < arrayLengthLocal - 10; i += 10)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        MainWindow.Text += Form1.arrayMain[i + j] + " ";
                    }
                    MainWindow.Text += Environment.NewLine;
                }
                if (arrayLengthLocal % 10 != 0)
                    for (int j = arrayLengthLocal - arrayLengthLocal % 10; j < arrayLengthLocal; j++)
                    {
                        MainWindow.Text += Form1.arrayMain[j] + " ";
                    }
                else
                    for (int j = arrayLengthLocal - 10; j < arrayLengthLocal; j++)
                    {
                        MainWindow.Text += Form1.arrayMain[j] + " ";
                    }
            }
        }
        public Form4()
        {
            InitializeComponent();
            dialogResult = MessageBox.Show("Набирать массив по порядку ввода? При выборе нет массив будет напечатан постоянно и меняться в реальном времени.", "", MessageBoxButtons.YesNo);
        switch(dialogResult)
            {
                case DialogResult.Yes:
                    ArrayPrinter(arrayLength, countdown);
                    break;

                case DialogResult.No:
                    ArrayPrinter(Form1.arrayLength, countdown);
                    break;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int x;
            bool isCorrect = int.TryParse(text, out x);
            if (isCorrect && x < 100 && x > -100)
            {
                Form1.arrayMain[arrayLength] = x;
                arrayLength++;
            }
            else
                MessageBox.Show("Введите число в диапазоне -100 < x < 100, либо попросите программиста переписать границы генерации чисел.", "Ошибка");

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    ArrayPrinter(arrayLength, countdown);                    
                    break;
                case DialogResult.No:
                    ArrayPrinter(Form1.arrayLength, countdown);
                    break;
            }
            if (arrayLength == Form1.arrayLength)
                this.Close();
            textBox1.Text = "";
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            arrayLength++;
            if (arrayLength == Form1.arrayLength)
                this.Close();
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    ArrayPrinter(arrayLength, countdown);
                    break;
                case DialogResult.No:
                    ArrayPrinter(Form1.arrayLength, countdown);
                    break;
            }
            
        }
    }
}
