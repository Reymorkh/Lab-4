using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;

namespace Лабораторная_4
{
  public partial class Tasks345Form : Form
  {
    public string a = "-101", b = "-101";
    public static int index1 = -1, index2 = -1;
    public List<Button> buttons = new List<Button>();
    public int fromTop = 100, fromLeft = 10, tabindex = 8, nameint = 0;
    bool swapMode = false;

    public Tasks345Form()
    {
      InitializeComponent();
      fromTop = 100; fromLeft = 10;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      if (MainMenuForm.arrayLength != 0)
        ButtonPrinterv3();
    }

    private void DynamicButtonOnClick(object sender, EventArgs eventArgs)
    {
      var button = (Button)sender;
      switch (swapMode)
      {
        case true:
          {

            if (button != null)
            {
              if (a == "-101")
              {
                a = button.Text;
                index1 = buttons.IndexOf(button);
              }
              else
              if (b == "-101" && a != button.Text)
              {
                b = button.Text;
                index2 = buttons.IndexOf(button);
              }

              if (a != "-101" && b != "-101")
              {
                (MainMenuForm.arrayMain[index1], MainMenuForm.arrayMain[index2]) = (MainMenuForm.arrayMain[index2], MainMenuForm.arrayMain[index1]);
                (buttons[index1].Text, buttons[index2].Text) = (buttons[index2].Text, buttons[index1].Text);

                a = "-101";
                b = "-101";
                index1 = -1;
                index2 = -1;
              }
            }
          }
          break;
        case false:
          {
            RewriteForm.index = buttons.IndexOf(button);
            RewriteForm gg = new RewriteForm();
            gg.ShowDialog();
            gg.Dispose();
            ButtonRewrite();
            //ButtonEraser();
            //ButtonPrinter();
          }
          break;
      }
    }

    private void GuideButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show("AddStart - добавляет введённое число в начало массива" + Environment.NewLine +
          "AddEnd - добавляет введённое число в конец массива." + Environment.NewLine +
          "AddX - добавляет введённое количество чисел в начало массиво." + Environment.NewLine +
          "Del - удаляет введённый номер элемента из массива." + Environment.NewLine +
          "DelMax - удаляет максимальный элемент из массива" + Environment.NewLine + Environment.NewLine +
          "Для входа в режим перестановки элементов поставьте галочки напротив соответствующего режима.", "Help");
    }

    private void AddToStart_Click(object sender, EventArgs e)
    {
      int number;
      if (int.TryParse(textBox1.Text, out number) && number > -100 && number < 100)
      {
        MainMenuForm.arrayLength++;
        MainMenuForm.arrayMain = MainMenuForm.Resize(MainMenuForm.arrayLength);
        MainMenuForm.arrayMain[MainMenuForm.arrayLength - 1] = number;
        for (int i = MainMenuForm.arrayLength - 2; i > -1; i--)
          (MainMenuForm.arrayMain[i], MainMenuForm.arrayMain[i + 1]) = (MainMenuForm.arrayMain[i + 1], MainMenuForm.arrayMain[i]);
        AddButton(MainMenuForm.arrayLength - 1);
        ButtonRewrite();
      }
      else
        MessageBox.Show("Введённые данныене являются числом в пределах (-100;100).", "Предупреждение");
    }

    private void AddToEndButton_Click(object sender, EventArgs e)
    {
      int number;
      if (int.TryParse(textBox1.Text, out number) && number > -100 && number < 100)
      {
        number = Convert.ToInt32(textBox1.Text);
        MainMenuForm.arrayLength++;
        MainMenuForm.arrayMain = MainMenuForm.Resize(MainMenuForm.arrayLength);
        MainMenuForm.arrayMain[MainMenuForm.arrayLength - 1] = number;
        AddButton(MainMenuForm.arrayLength - 1);
        ButtonRewrite();
      }
      else
        MessageBox.Show("Введённые данныене являются числом в пределах (-100;100).", "Предупреждение");
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
      int index;
      if (int.TryParse(textBox1.Text, out index) && index > 0 && index <= MainMenuForm.arrayLength)
      {
        for (int i = index - 1; i < MainMenuForm.arrayLength - 1; i++)
          MainMenuForm.arrayMain[i] = MainMenuForm.arrayMain[i + 1];
        MainMenuForm.arrayLength--;
        MainMenuForm.arrayMain = MainMenuForm.Resize(MainMenuForm.arrayLength);
        if (MainMenuForm.arrayLength != 0)
          ButtonSingularEraser(MainMenuForm.arrayLength);
        else
          ButtonSingularEraser(0);
        ButtonRewrite();
      }
      else
        MessageBox.Show("Вы ввели число за границами массива.", "Предупреждение");
    }

    private void DelMax_Click(object sender, EventArgs e)
    {
      if (MainMenuForm.arrayLength != 0)
      {
        int max = -101, index = -1;
        for (int i = 0; i < MainMenuForm.arrayLength; i++)
        {
          if (max < MainMenuForm.arrayMain[i])
          {
            max = MainMenuForm.arrayMain[i];
            index = i;
          }
        }
        MainMenuForm.arrayLength--;
        for (int i = index; i < MainMenuForm.arrayLength; i++)
          (MainMenuForm.arrayMain[i], MainMenuForm.arrayMain[i + 1]) = (MainMenuForm.arrayMain[i + 1], MainMenuForm.arrayMain[i]);
        MainMenuForm.arrayMain = MainMenuForm.Resize(MainMenuForm.arrayLength);
        if (MainMenuForm.arrayLength != 0)
          ButtonSingularEraser(MainMenuForm.arrayLength);
        else
          ButtonSingularEraser(0);
        ButtonRewrite();
      }
      else
        MessageBox.Show("Массива нет.", "Предупреждение");
    }

    private void Addx_Click(object sender, EventArgs e)
    {
      int x;
      if (int.TryParse(textBox1.Text, out x) && x > 0)
      {
        MainMenuForm.arrayLength += x;
        MainMenuForm.arrayMain = MainMenuForm.Resize(MainMenuForm.arrayLength);
        for (int j = 0; j < x; j++)
          for (int i = MainMenuForm.arrayLength - 2; i > -1; i--)
            (MainMenuForm.arrayMain[i], MainMenuForm.arrayMain[i + 1]) = (MainMenuForm.arrayMain[i + 1], MainMenuForm.arrayMain[i]);
        for (int i = MainMenuForm.arrayLength - x; i < MainMenuForm.arrayLength; i++)
          AddButton(i);
        ButtonRewrite();
      }
      else
        MessageBox.Show("Введённые данныене являются числом в пределах (-100;100).", "Предупреждение");
    }

    public void AddButton(int i)
    {

      Button newButton = new Button();
      newButton.Location = new Point(fromLeft, fromTop);

      if (fromLeft < 550)
      {
        fromLeft += 60;
      }
      else
      {
        fromLeft = 10;
        fromTop += 40;
      }

      buttons.Add(newButton);
      newButton.Size = new Size(40, 20);
      newButton.TabIndex = tabindex;
      tabindex++;
      newButton.Click += DynamicButtonOnClick;
      newButton.Text = Convert.ToString(MainMenuForm.arrayMain[i]);
      Controls.Add(newButton);
    } //работает великолепно

    public void ButtonRewrite()
    {
      for (int i = 0; i < MainMenuForm.arrayLength; i++)
      {
        //MessageBox.Show(Convert.ToString(i) + "   " + Convert.ToString(Form1.arrayLength), "");
        buttons[i].Text = Convert.ToString(MainMenuForm.arrayMain[i]);
      }
    } //работает

    public void ButtonPrinterv3() //Работает как швейцарские часы
    {
      for (int i = 0; i < MainMenuForm.arrayLength; i++)
        AddButton(i);
    }

    public void ButtonSingularEraser(int i)
    {
      buttons[i].Dispose();
      buttons.RemoveAt(i);
      if (fromLeft > 10)
      {
        fromLeft -= 60;
      }
      else
      {
        fromLeft = 550;
        fromTop -= 40;
      }
    }

    private void SwapModeCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      switch(swapMode)
      {
        case (true):
          swapMode = false;
          a = b;
          break;
        case false:
          swapMode = true;
          break;
      }
    }
  }
}