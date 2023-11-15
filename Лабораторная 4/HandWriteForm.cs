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
  public partial class HandWriteForm : Form
  {
    public int arrayLength, countdown;
    DialogResult dialogResult;

    public void ArrayPrinter(int arrayLengthLocal)
    {
      string[] text = new string[MainMenuForm.arrayLength];
      text[0] = "Вам осталось " + (MainMenuForm.arrayLength - countdown) + " элементов. Вид массива прямо сейчас:" + Environment.NewLine;

      if (arrayLength != 0 || arrayLengthLocal != 0)
      {
        int i;
        for (i = 0; i < arrayLengthLocal - 10; i += 10)
        {
          for (int j = 0; j < 10; j++)
          {
            text[0] = "Вам осталось " + (MainMenuForm.arrayLength - countdown) + " элементов. Вид массива прямо сейчас:" + Environment.NewLine;
            text[1 + i] += MainMenuForm.arrayMain[i + j] + " ";
            MainWindow.Text = string.Join('\n', text);
          }
          text[1 + i] += Environment.NewLine;
        }
        i++;
        if (arrayLengthLocal % 10 != 0)
          for (int j = arrayLengthLocal - arrayLengthLocal % 10; j < arrayLengthLocal; j++)
          {
            text[0] = "Вам осталось " + (MainMenuForm.arrayLength - countdown) + " элементов. Вид массива прямо сейчас:" + Environment.NewLine;
            text[1 + i] += MainMenuForm.arrayMain[j] + " ";
            MainWindow.Text = string.Join('\n', text);
          }
        else
          for (int j = arrayLengthLocal - 10; j < arrayLengthLocal; j++)
          {
            text[0] = "Вам осталось " + (arrayLength - countdown) + " элементов. Вид массива прямо сейчас:" + Environment.NewLine;
            text[1 + i] += MainMenuForm.arrayMain[j] + " ";
            MainWindow.Text = string.Join('\n', text);
          }
      }
    }

    public HandWriteForm()
    {
      InitializeComponent();
      arrayLength = 0;
      countdown = 0;
      dialogResult = MessageBox.Show("Набирать массив по порядку ввода? При выборе нет массив будет напечатан постоянно и меняться в реальном времени.", "", MessageBoxButtons.YesNo);
      MainWindow.Text = "Вам осталось " + Convert.ToString(MainMenuForm.arrayLength) + " элементов. Вид массива прямо сейчас:";
      switch (dialogResult)
      {
        case DialogResult.Yes:
          ArrayPrinter(arrayLength);
          break;

        case DialogResult.No:
          ArrayPrinter(MainMenuForm.arrayLength);
          break;
      }
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
      string text = textBox1.Text;
      int x;
      if (int.TryParse(text, out x) && x < 100 && x > -100)
      {
        MainMenuForm.arrayMain[arrayLength] = x;
        arrayLength++;
        countdown++;
      }
      else
        MessageBox.Show("Введите число в диапазоне -100 < x < 100, либо попросите программиста переписать границы генерации чисел.", "Ошибка");

      switch (dialogResult)
      {
        case DialogResult.Yes:
          ArrayPrinter(arrayLength);
          break;
        case DialogResult.No:
          ArrayPrinter(MainMenuForm.arrayLength);
          break;
      }
      if (arrayLength == MainMenuForm.arrayLength)
        this.Close();
      textBox1.Text = "";
    }

    private void SkipButton_Click(object sender, EventArgs e)
    {
      arrayLength++;
      countdown++;
      if (arrayLength == MainMenuForm.arrayLength)
        this.Close();
      switch (dialogResult)
      {
        case DialogResult.Yes:
          ArrayPrinter(arrayLength);
          break;
        case DialogResult.No:
          ArrayPrinter(MainMenuForm.arrayLength);
          break;
      }
    }
  }
}
    