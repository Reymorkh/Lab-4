using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_4
{
  public partial class RewriteForm : Form
  {
    public static int index;
    public RewriteForm()
    {
      InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text = textBox1.Text;
      int x;
      bool isCorrect = int.TryParse(text, out x);
      if (isCorrect && (x < 100) && (x > -100))
      {
        MainMenuForm.arrayMain[index] = x;
        this.Close();
      }
      else
        MessageBox.Show("Введите число в диапазоне -100 < x < 100, либо попросите программиста переписать границы генерации чисел.", "Ошибка");
    }
  }
}
