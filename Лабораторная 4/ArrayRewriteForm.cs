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
  public partial class ArrayRewriteForm : Form
  {
    public int arrayLength = 0, countdown = 0;
    DialogResult realTimeMode;

    void ArrayPrinter()
    {
      MainWindow.Text = "Вам осталось " + (MainMenuForm.arrayLength - countdown) + " элементов.Вид массива прямо сейчас:" + Environment.NewLine;
      switch (realTimeMode)
      {
        case DialogResult.Yes:
          for (int i = 0; i < arrayLength; i += 10)
            if (arrayLength > i + 10)
              MainWindow.Text += MainMenuForm.RowPrint(i, i + 10) + Environment.NewLine + (i / 10 + 2) + ".   ";
            else
              MainWindow.Text += MainMenuForm.RowPrint(i, arrayLength);
          break;
        case DialogResult.No:
          for (int i = 0; i < MainMenuForm.arrayLength; i += 10)
            if (MainMenuForm.arrayLength > i + 10)
              MainWindow.Text += MainMenuForm.RowPrint(i, i + 10) + Environment.NewLine + (i / 10 + 2) + ".   ";
            else
              MainWindow.Text += MainMenuForm.RowPrint(i, MainMenuForm.arrayLength);
          break;
      }

      countdown++;
    }

    public ArrayRewriteForm()
    {
      InitializeComponent();
      realTimeMode = MessageBox.Show("Набирать массив по порядку ввода? При выборе нет массив будет напечатан постоянно и меняться в реальном времени.", "", MessageBoxButtons.YesNo);
      ArrayPrinter();
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
      string text = textBox1.Text;
      int x;
      if (int.TryParse(text, out x) && x < 100 && x > -100)
      {
        if (MainMenuForm.isSorted == true)
          MainMenuForm.isSorted = false;
        MainMenuForm.arrayMain[arrayLength] = x;
        arrayLength++;
        if (arrayLength == MainMenuForm.arrayLength)
          this.Close();
        ArrayPrinter();
        textBox1.Text = "";
      }
      else
        MessageBox.Show("Введите число в диапазоне -100 < x < 100, либо попросите программиста переписать границы генерации чисел.", "Ошибка");


    }

    private void SkipButton_Click(object sender, EventArgs e)
    {
      if (MainMenuForm.isSorted == true)
        MainMenuForm.isSorted = false;
      arrayLength++;
      if (arrayLength == MainMenuForm.arrayLength)
        this.Close();
      ArrayPrinter();
    }
  }
}
