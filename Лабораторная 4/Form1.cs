using System.Numerics;
using System.Reflection.Metadata;

namespace Лабораторная_4
{
    public partial class Form1 : Form
    {
        public static int arrayLength = 0, cycleRight, cycleDown;
        public static int[] arrayMain;
        public static Random random = new Random();
        public int hasBeenAdded = 0;
        public bool isSorted = false;

        int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pen = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pen++;
                    SwapInt(ref array[pen], ref array[i]);
                }
            }

            pen++;
            SwapInt(ref array[pen], ref array[maxIndex]);
            return pen;
        }

        int[] HoarahSort(int[] array, int indexLeft, int indexRight)
        {
            if (indexLeft >= indexRight)
            {
                return array; //финальная сдача массива
            }

            var pivotIndex = Partition(array, indexLeft, indexRight); // определение опорного элемента в массиве и перестановка
            HoarahSort(array, indexLeft, pivotIndex - 1); // сорт по краям от опорного элемента
            HoarahSort(array, pivotIndex + 1, indexRight); // сорт по краям от опорного элемента

            return array;
        }

        public static void SwapInt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void ArrayPrinter()
        {
            MainWindow.Text = "Длина массива записана как: " + arrayLength;
            MainWindow.Text += Environment.NewLine;
            if (arrayLength != 0)
            {
                for (int i = 0; i < arrayMain.Length; i++)
                    if (arrayMain[i] != 0)
                        if (arrayMain[i] % 2 == 0)
                        {
                            MainWindow.Text += "Первое чётное число: " + arrayMain[i] + " с индексом: " + i + Environment.NewLine;
                            break;
                        }
                for (int i = 0; i < arrayLength - 10; i += 10)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        MainWindow.Text += arrayMain[i + j] + " ";
                    }
                    MainWindow.Text += Environment.NewLine;
                }
                if (arrayLength % 10 != 0)
                    for (int j = arrayLength - arrayLength % 10; j < arrayLength; j++)
                    {
                        MainWindow.Text += arrayMain[j] + " ";

                    }
                else
                    for (int j = arrayLength - 10; j < arrayLength; j++)
                    {
                        MainWindow.Text += arrayMain[j] + " ";

                    }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void PlaceSwapper_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            f.Dispose();
            ArrayPrinter();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Поле ввода")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поле ввода";
                textBox1.ForeColor = Color.Gray;
            }

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            bool arrayAssignCheck = false;
            if (arrayLength == 0)
                arrayAssignCheck = true;
            bool isCorrect = int.TryParse(textBox1.Text, out arrayLength);
            if (isCorrect)
            {
                if (arrayLength < Convert.ToInt32(textBox1.Text))
                    hasBeenAdded -= arrayLength - Convert.ToInt32(textBox1.Text);
                else if (arrayLength > Convert.ToInt32(textBox1.Text))
                    hasBeenAdded += Convert.ToInt32(textBox1.Text) - arrayLength;

                arrayLength = Convert.ToInt32(textBox1.Text);
                Array.Resize(ref arrayMain, arrayLength);

                if (arrayAssignCheck)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы инициализировали новый массив. Заполнить его?", "Notification.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        arrayAssignCheck = false;
                        RandomFiller_Click(sender, e);
                    }
                }
            }



            if (arrayLength == 0)
            {
                SearchOut.Visible = false;
                SearchButton.Visible = false;
            }
            if (arrayLength > 0)
            {
                SearchOut.Visible = true;
                SearchButton.Visible = true;
                
            }
            ArrayPrinter();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainButton_Click(sender, e);
            }
        }

        private void RandomFiller_Click(object sender, EventArgs e)
        {
            if (arrayLength != 0)
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    arrayMain[i] = random.Next(-100, 100);
                }
                ArrayPrinter();
            }
            else
                MessageBox.Show("Массива нет.", "Ошибка");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int plusX;

            if (int.TryParse(textBox1.Text, out plusX))
                if (Convert.ToInt32(textBox1.Text) + arrayLength < 2147483646)
                {
                    arrayLength += plusX;
                    hasBeenAdded += plusX;
                    Array.Resize(ref arrayMain, arrayLength);
                    ArrayPrinter();
                    if (!SearchButton.Visible)
                    {
                        SearchOut.Visible = true;
                        SearchButton.Visible = true;
                    }
                }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            int minusX;
            if (int.TryParse(textBox1.Text, out minusX))
                if (arrayLength - Convert.ToInt32(textBox1.Text) > -1)
                {
                    arrayLength -= minusX;
                    hasBeenAdded -= minusX;
                    Array.Resize(ref arrayMain, arrayLength);
                    if (arrayLength == 0)
                    { 
                        SearchOut.Visible = false;
                        SearchButton.Visible = false;
                    }
                    ArrayPrinter();
                }
                else
                    MessageBox.Show("Либо нечисло, либо вы хотите вычесть больше, чем есть длины.", "Ошибка");
        }

        private void NullRandom_Click(object sender, EventArgs e)
        {
            if (arrayLength != 0)
            {
                if (hasBeenAdded == 0)
                MessageBox.Show("Либо массива нет, либо после добавления элементов вы нажали сортировку.", "Ошибка");
                for (int i = arrayLength - hasBeenAdded; i < arrayLength; i++)
                {
                    if (arrayMain[i] == 0)
                        arrayMain[i] = random.Next(-100, 100);
                }
                hasBeenAdded = 0;
                ArrayPrinter();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int theNumber;
            int counter = 0;
            bool isCorrect = int.TryParse(textBox1.Text, out theNumber);
            if (isCorrect)
            {
                for (int i = 0; i < arrayLength; i++)
                    if (arrayMain[i] == theNumber)
                        counter++;
            }
            SearchOut.Text = ("Количество совпадений: " + counter);
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            if (arrayLength != 0)
            {
                Array.Reverse(arrayMain);
                ArrayPrinter();
            }
            else
                MessageBox.Show("Массива нет.", "Ошибка");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (arrayLength != 0)
            {
                HoarahSort(arrayMain, 0, arrayLength - 1);
                hasBeenAdded = 0;
                ArrayPrinter();
            }
            else
                MessageBox.Show("Массива нет.", "Ошибка");
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (arrayLength != 0)
                ArrayPrinter();
        }
        private void ArrayEnterButton_Click(object sender, EventArgs e)
        {
            if (arrayLength != 0)
            {
                Form4 gg = new Form4();
                gg.ShowDialog();
                gg.Dispose();
                ArrayPrinter();
            }
            else
                MessageBox.Show("Массив-то создайте.", "Ошибка");
        }

        //пустые события
        private void MainWindow_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }

}