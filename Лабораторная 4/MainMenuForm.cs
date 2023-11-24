using System.Numerics;
using System.Reflection.Metadata;

namespace Лабораторная_4
{
  public partial class MainMenuForm : Form
  {
    public static int arrayLength = 0;
    public static int[] arrayMain = new int[0];
    static Random random = new Random();
    int hasBeenAdded = 0;
    public static bool isSorted = false;

    public static new int[] Resize(int length)
    {
      int[] array = new int[length];
      for (int i = 0; i < length & i < arrayMain.Length; i++)
        array[i] = arrayMain[i];
      return array;
    }

    int Partition(int[] array, int indexLeft, int indexRight)
    {
      int pen = indexLeft - 1;
      for (int i = indexLeft; i < indexRight; i++)
      {
        if (array[i] < array[indexRight])
        {
          pen++;
          (array[pen], array[i]) = (array[i], array[pen]);
        }
      }
      pen++;
      (array[pen], array[indexRight]) = (array[indexRight], array[pen]);
      return pen;
    }

    int[] HoarahSort(int[] array, int indexLeft, int indexRight)
    {
      if (indexLeft >= indexRight)
      {
        return array; //финальная сдача массива
      }
      int pivotIndex = Partition(array, indexLeft, indexRight); // определение опорного элемента в массиве и перестановка
      HoarahSort(array, indexLeft, pivotIndex - 1); // сорт по левому краю от опорного элемента
      HoarahSort(array, pivotIndex + 1, indexRight); // сорт по правому краю от опорного элемента

      return array;
    }

    public static string RowPrint(int leftIndex, int rightIndex)
    {
      string row = String.Empty;
      for (int i = leftIndex; i < rightIndex; i++)
        if (i != rightIndex - 1)
          row += arrayMain[i] + " ";
        else
          row += arrayMain[i];
      return row;
    }

    void ArrayPrinter()
    {
      MainWindow.Text = "Длина массива записана как: " + arrayLength + Environment.NewLine + 1 + ".   ";
      for (int i = 0; i < arrayLength; i += 10)
        if (arrayLength > i + 10)
          MainWindow.Text += RowPrint(i, i + 10) + Environment.NewLine + (i / 10 + 2) + ".   ";
        else
          MainWindow.Text += RowPrint(i, arrayLength);
      //for (int i = 0; i < arrayMain.Length; i++)
      //  if (arrayMain[i] != 0)
      //    if (arrayMain[i] % 2 == 0)
      //    {
      //      MainWindow.Text += "Первое чётное число: " + arrayMain[i] + " с индексом: " + i + Environment.NewLine;
      //      break;
      //    }
      //for (int i = 0; i < arrayLength - 10; i += 10)
      //{
      //  for (int j = 0; j < 10; j++)
      //  {
      //    MainWindow.Text += arrayMain[i + j] + " ";
      //  }
      //  MainWindow.Text += Environment.NewLine;
      //}
      //if (arrayLength % 10 != 0)
      //  for (int j = arrayLength - arrayLength % 10; j < arrayLength; j++)
      //  {
      //    MainWindow.Text += arrayMain[j] + " ";

      //  }
      //else
      //  for (int j = arrayLength - 10; j < arrayLength; j++)
      //  {
      //    MainWindow.Text += arrayMain[j] + " ";

      //  }

    }

    public MainMenuForm()
    {
      InitializeComponent();
    }

    void PlaceSwapper_Click(object sender, EventArgs e)
    {
      Tasks345Form f = new Tasks345Form();
      f.ShowDialog();
      f.Dispose();
      if (arrayLength != 0 && !EvenSearchButton.Visible)
      {
        EvenSearchButton.Visible = true;
        EvenSearchLabel.Visible = true;
        BinarySearchBox.Visible = true;
        BinarySearchButton.Visible = true;
        BinarySearchLabel.Visible = true;
      }
      else
      {
        EvenSearchButton.Visible = false;
        EvenSearchLabel.Visible = false;
        BinarySearchBox.Visible = false;
        BinarySearchButton.Visible = false;
        BinarySearchLabel.Visible = false;
      }
      ArrayPrinter();
    }

    void textBox1_Enter(object sender, EventArgs e)
    {
      if (textBox1.Text == "Поле ввода")
      {
        textBox1.Text = "";
        textBox1.ForeColor = Color.Black;
      }
    }

    void textBox1_Leave(object sender, EventArgs e)
    {
      if (textBox1.Text == "")
      {
        textBox1.Text = "Поле ввода";
        textBox1.ForeColor = Color.Gray;
      }
    }

    void EnterButton_Click(object sender, EventArgs e)
    {
      bool arrayAssignCheck = false;
      if (arrayLength == 0)
        arrayAssignCheck = true;
      if (int.TryParse(textBox1.Text, out arrayLength))
      {
        if (arrayLength > arrayMain.Length)
          hasBeenAdded += arrayLength - arrayMain.Length;
        else if (arrayMain.Length - arrayLength > hasBeenAdded)
          hasBeenAdded = 0;
        else
          hasBeenAdded -= arrayMain.Length - arrayLength;

        isSorted = false;
        arrayLength = Convert.ToInt32(textBox1.Text);
        arrayMain = Resize(arrayLength);

        if (arrayAssignCheck)
        {
          DialogResult dialogResult = MessageBox.Show("Вы инициализировали новый массив. Заполнить его?", "Notification.", MessageBoxButtons.YesNo);
          if (dialogResult == DialogResult.Yes)
          {
            RandomFiller_Click(sender, e);
          }
        }
      }

      if (arrayLength == 0)
      {
        EvenSearchLabel.Visible = false;
        EvenSearchButton.Visible = false;
        BinarySearchBox.Visible = false;
        BinarySearchButton.Visible = false;
        BinarySearchLabel.Visible = false;
      }
      else
      {
        EvenSearchLabel.Visible = true;
        EvenSearchButton.Visible = true;
        BinarySearchBox.Visible = true;
        BinarySearchButton.Visible = true;
        BinarySearchLabel.Visible = true;
      }
      ArrayPrinter();
    }

    void TextBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        EnterButton_Click(sender, e);
      }
    }

    void RandomFiller_Click(object sender, EventArgs e)
    {
      if (arrayLength != 0)
      {
        isSorted = false;
        for (int i = 0; i < arrayLength; i++)
        {
          arrayMain[i] = random.Next(-100, 100);
        }
        ArrayPrinter();
      }
      else
        MessageBox.Show("Массива нет.", "Ошибка");
    }

    void PlusButton_Click(object sender, EventArgs e)
    {
      int plusX;
      if (int.TryParse(textBox1.Text, out plusX) && plusX + arrayLength < 2147483646)
      {
        isSorted = false;
        arrayLength += plusX;
        hasBeenAdded += plusX;
        arrayMain = Resize(arrayLength);
        ArrayPrinter();
        if (!EvenSearchButton.Visible)
        {
          EvenSearchLabel.Visible = true;
          EvenSearchButton.Visible = true;
          BinarySearchBox.Visible = true;
          BinarySearchButton.Visible = true;
          BinarySearchLabel.Visible = true;
        }
      }
    }

    void MinusButton_Click(object sender, EventArgs e)
    {
      int minusX;
      if (int.TryParse(textBox1.Text, out minusX))
        if (arrayLength - Convert.ToInt32(textBox1.Text) > -1)
        {
          arrayLength -= minusX;
          hasBeenAdded -= minusX;
          arrayMain = Resize(arrayLength);
          if (arrayLength == 0)
          {
            EvenSearchLabel.Visible = false;
            EvenSearchButton.Visible = false;
            BinarySearchBox.Visible = false;
            BinarySearchButton.Visible = false;
            BinarySearchLabel.Visible = false;
          }
          ArrayPrinter();
        }
        else
          MessageBox.Show("Либо нечисло, либо вы хотите вычесть больше, чем есть длины.", "Ошибка");
    }

    void FillNewRandom_Click(object sender, EventArgs e)
    {
      if (arrayLength != 0)
      {
        if (hasBeenAdded == 0)
          MessageBox.Show("Либо массива нет, либо нет новых элементов, либо после добавления элементов вы нажали сортировку.", "Ошибка");
        else
          isSorted = false;
        for (int i = arrayLength - hasBeenAdded; i < arrayLength; i++)
        {
          if (arrayMain[i] == 0)
            arrayMain[i] = random.Next(-100, 100);
        }
        hasBeenAdded = 0;
        ArrayPrinter();
      }
    }

    void SearchButton_Click(object sender, EventArgs e)
    {
      int i;
      for (i = 0; i < arrayLength && arrayMain[i] % 2 != 0; i++) ;
      if (arrayMain[i] % 2 != 0)
        i = -1;
      if (i < 0)
        EvenSearchLabel.Text = "Элемент не найден.";
      else
        EvenSearchLabel.Text = "Первый чётный элемент: " + (i + 1);
    }

    void ReverseButton_Click(object sender, EventArgs e)
    {
      if (arrayLength != 0)
      {
        isSorted = false;
        arrayMain = Reverse();
        ArrayPrinter();
      }
      else
        MessageBox.Show("Массива нет.", "Ошибка");
    }

    int[] Reverse()
    {
      int j = arrayMain.Length - 1;
      int[] array = new int[j + 1];
      for (int i = 0; i < arrayMain.Length; i++, j--)
        array[i] = arrayMain[j];
      return array;
    }

    void SortButton_Click(object sender, EventArgs e)
    {
      if (arrayLength != 0)
      {
        HoarahSort(arrayMain, 0, arrayLength - 1);
        hasBeenAdded = 0;
        ArrayPrinter();
        isSorted = true;
      }
      else
        MessageBox.Show("Массива нет.", "Ошибка");
    }

    void ArrayRewriteButton_Click(object sender, EventArgs e)
    {
      if (arrayLength != 0)
      {
        ArrayRewriteForm form = new ArrayRewriteForm();
        form.ShowDialog();
        form.Dispose();
        ArrayPrinter();
      }
      else
        MessageBox.Show("Массив-то создайте.", "Ошибка");
    }

    void BinarySearchButton_Click(object sender, EventArgs e)
    {
      int number;
      if (isSorted && int.TryParse(BinarySearchBox.Text, out number))
      {
        int index = BinarySearch(number, 0, arrayLength);
        if (index > -1)
          BinarySearchLabel.Text = $"Номер искомого элемента {index}: " + Convert.ToString(number + 1);
        else
          BinarySearchLabel.Text = "Элемент не найден";
      }
      else
        MessageBox.Show("Либо массив не отсортирован, либо введённое значение не соответствует типу integer в пределах (-100;100).", "Ошибка");
    }

    int BinarySearch(int searchedNumber, int indexLeft, int indexRight)
    {
      while (indexLeft <= indexRight)
      {
        int index = (indexLeft + indexRight) / 2;
        if (searchedNumber == arrayMain[index])
        {
          return index;
        }
        else if (searchedNumber < arrayMain[index])
        {
          indexRight = index - 1;
        }
        else
        {
          indexLeft = index + 1;
        }
      }
      return -1;
    }
  }
}