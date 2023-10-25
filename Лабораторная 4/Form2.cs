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
    public partial class Form2 : Form
    {
        public string a = "-101", b = "-101";
        public static int index1 = -1, index2 = -1;
        public List<Button> buttons = new List<Button>();
        public int fromTop = 100, fromLeft = 10, tabindex = 8, nameint = 0;

        public void SwapButton(Button first, Button second)
        {
            string temp = first.Text;
            first.Text = second.Text;
            second.Text = temp;

        }

        public void SwapString(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public void ButtonEraser()
        {
            foreach (var button in buttons)
            {
                button.Dispose();
            }
            buttons.Clear();
            fromLeft = 10;
            fromTop = 100;
        }

        public Form2()
        {
            InitializeComponent();
            fromTop = 100; fromLeft = 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.arrayLength != 0)
                ButtonPrinterv3();
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {  
            var button = (Button)sender;
            DialogResult dialogResult = MessageBox.Show("Вы хотите перезаписать значение выбранного элемента массива?" + Environment.NewLine +
                "При выборе варианта нет кнопка будет отмечена для обмена значениями." + Environment.NewLine +
                "При выборе отмены это окно закроется.", "Ща будет сложно", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.No)
            {

                if (button != null)
                {
                    buttons.IndexOf(button);


                    if (a == "-101")
                    {
                        a = button.Text;
                        index1 = buttons.IndexOf(button);
                    }
                    else
                    if (b == "-101")
                    {
                        b = button.Text;
                        index2 = buttons.IndexOf(button);
                    }
                    if (a != "-101" && b != "-101")
                    {
                        Form1.SwapInt(ref Form1.arrayMain[index1], ref Form1.arrayMain[index2]);
                        SwapButton(buttons[index1], buttons[index2]);


                        a = "-101";
                        b = "-101";
                        index1 = -1;
                        index2 = -1;
                    }
                }
            }
            if (dialogResult == DialogResult.Yes)
            {
                Form3.index = buttons.IndexOf(button);
                Form3 gg = new Form3();
                gg.ShowDialog();
                gg.Dispose();
                ButtonRewrite();
                //ButtonEraser();
                //ButtonPrinter();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(textBox1.Text, out x))
            {
                //if (Convert.ToInt32(textBox1.Text) > 0)
                //{
                x = Convert.ToInt32(textBox1.Text);
                Form1.arrayLength++;
                Array.Resize(ref Form1.arrayMain, Form1.arrayLength);
                Form1.arrayMain[Form1.arrayLength - 1] = x;
                AddButton(Form1.arrayLength - 1);
                ButtonRewrite();
            }
            else
                MessageBox.Show("Нечисло.", "Предупреждение");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(textBox1.Text, out x))
            {
                x = Convert.ToInt32(textBox1.Text);
                if (x > 0 && x <= Form1.arrayLength)
                {
                    x = Convert.ToInt32(textBox1.Text);
                    Form1.arrayMain[x - 1] = 0;
                    for (int i = x - 1; i < Form1.arrayLength - 1; i++)
                        Form1.arrayMain[i] = Form1.arrayMain[i + 1];
                    Form1.arrayLength--;
                    Array.Resize(ref Form1.arrayMain, Form1.arrayLength);
                    if (Form1.arrayLength != 0)
                        ButtonSnipeEraser(Form1.arrayLength);
                }
                else
                    MessageBox.Show("Вы ввели число за границами массива.", "Предупреждение");
            }
            else
                MessageBox.Show("Нечисло.", "Предупреждение");
        }

        private void guideButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddStart - добавляет введённое число в начало массива" + Environment.NewLine +
                "AddEnd - добавляет введённое число в конец массива." + Environment.NewLine +
                "AddX - добавляет введённое количество чисел в начало массиво." + Environment.NewLine +
                "Del - удаляет введённый номер элемента из массива." + Environment.NewLine +
                "DelMax - удаляет максимальный элемент из массива" + Environment.NewLine + Environment.NewLine +
                "Для оперестановки элементов нажмите на оба элемента, которые хотите поменять местами.", "Help");
        }

        private void DelMax_Click(object sender, EventArgs e)
        {
            if (Form1.arrayLength != 0)
            {
                int max = -100, index = 0;
                for (int i = 0; i < Form1.arrayLength; i++)
                {
                    if (max < Form1.arrayMain[i])
                    {
                        max = Form1.arrayMain[i];
                        index = i;
                    }
                }
                Form1.arrayLength -= 1;
                for (int i = index; i < Form1.arrayLength; i++)
                    Form1.SwapInt(ref Form1.arrayMain[i], ref Form1.arrayMain[i + 1]);
                Array.Resize(ref Form1.arrayMain, Form1.arrayLength);
                if (Form1.arrayLength != 0)
                    ButtonSnipeEraser(Form1.arrayLength);
            }
            else
                MessageBox.Show("Массива нет.", "Предупреждение");
        }

        private void AddStart_Click(object sender, EventArgs e)
        {
            int x;
            bool isCorrect = int.TryParse(textBox1.Text, out x);
            if (isCorrect)
            {
                Form1.arrayLength++;
                Array.Resize(ref Form1.arrayMain, Form1.arrayLength);
                Form1.arrayMain[Form1.arrayLength - 1] = x;
                for (int i = Form1.arrayLength - 2; i > -1; i--)
                    Form1.SwapInt(ref Form1.arrayMain[i], ref Form1.arrayMain[i + 1]);
                AddButton(Form1.arrayLength - 1);
                ButtonRewrite();
            }
        }

        private void Addx_Click(object sender, EventArgs e)
        {
            int x;
            bool isCorrect = int.TryParse(textBox1.Text, out x);
            if (isCorrect && x > 0)
            {
                Form1.arrayLength += x;
                Array.Resize(ref Form1.arrayMain, Form1.arrayLength);
                for (int j = 0; j < x; j++)
                    for (int i = Form1.arrayLength - 2; i > -1; i--)
                        Form1.SwapInt(ref Form1.arrayMain[i], ref Form1.arrayMain[i + 1]);
                for (int i = Form1.arrayLength - x;  i < Form1.arrayLength; i++)
                    AddButton(i);
                ButtonRewrite();
            }
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
            newButton.Click += ButtonOnClick;
            newButton.Text = Convert.ToString(Form1.arrayMain[i]);
            Controls.Add(newButton);
        } //работает великолепно

        public void ButtonRewrite()
        {
            for (int i = 0; i < Form1.arrayLength; i++)
            {
                //MessageBox.Show(Convert.ToString(i) + "   " + Convert.ToString(Form1.arrayLength), "");
                buttons[i].Text = Convert.ToString(Form1.arrayMain[i]);
            }
        } //работает

        public void ButtonPrinterv3() //Работает как швейцарские часы
        {
            for (int i = 0; i < Form1.arrayLength; i++)
                AddButton(i);
        }

        public void ButtonSnipeEraser(int i)
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
    }
}