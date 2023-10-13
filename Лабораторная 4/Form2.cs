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
        public int index1 = -1, index2 = -1;
        public List<Button> buttons = new List<Button>();
        public int fromTop = 100, fromLeft = 10, tabindex = 8, nameint = 0;
        //public string bName = "newButton";


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

        public void ButtonPrinter()
        {

            string name = "newButton";
            int nameInt = 0;
            for (int i = 0; i < Form1.arrayLength - 10; i += 10)
            {
                fromLeft = 10;
                for (int j = 0; j < 10; j++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(fromLeft, fromTop);
                    fromLeft += 60;

                    //newButton.Name = name + Convert.ToString(nameInt);
                    buttons.Add(newButton);
                    nameInt++;
                    newButton.Size = new Size(40, 20);
                    newButton.TabIndex = tabindex;
                    tabindex++;
                    newButton.Click += ButtonOnClick;
                    newButton.Text = Convert.ToString(Form1.arrayMain[i + j]);
                    Controls.Add(newButton);
                }
                fromTop += 40;
            }


            fromLeft = 10;

            if (Form1.arrayLength % 10 != 0)
                for (int j = Form1.arrayLength - Form1.arrayLength % 10; j < Form1.arrayLength; j++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(fromLeft, fromTop);
                    fromLeft += 60;

                    newButton.Name = name + Convert.ToString(nameInt);
                    buttons.Add(newButton);
                    nameInt++;
                    newButton.Size = new Size(40, 20);
                    newButton.TabIndex = tabindex;
                    tabindex++;
                    newButton.Click += ButtonOnClick;
                    newButton.Text = Convert.ToString(Form1.arrayMain[j]);
                    Controls.Add(newButton);
                }
            else
                for (int j = Form1.arrayLength - 10; j < Form1.arrayLength; j++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(fromLeft, fromTop);
                    fromLeft += 60;

                    newButton.Name = name + Convert.ToString(nameInt);
                    buttons.Add(newButton);
                    nameInt++;
                    newButton.Size = new Size(40, 20);
                    newButton.TabIndex = tabindex;
                    tabindex++;
                    newButton.Click += ButtonOnClick;
                    newButton.Text = Convert.ToString(Form1.arrayMain[j]);
                    Controls.Add(newButton);
                }


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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            ButtonPrinter();



        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                buttons.IndexOf(button);


                if (a == "-101")
                {
                    a = button.Text;
                    index1 = buttons.IndexOf(button);
                    // MessageBox.Show(Convert.ToString(index1));
                }
                else
                if (b == "-101")
                {
                    b = button.Text;
                    index2 = buttons.IndexOf(button);
                    //MessageBox.Show(Convert.ToString(index2));
                }
                if (a != "-101" && b != "-101")
                {
                    Form1.SwapInt(ref Form1.arrayMain[index1], ref Form1.arrayMain[index2]);
                    SwapButton(buttons[index1],buttons[index2]);


                    a = "-101";
                    b = "-101";
                    index1 = -1;
                    index2 = -1;
                    //AddButton();
                    //ButtonRewrite();
                    //ButtonEraser();
                    //ButtonPrinter();
                }
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

                ButtonEraser();
                ButtonPrinter();
                //}
                //else
                //MessageBox.Show("Вы ввели число меньше нуля.", "Предупреждение");
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
                    ButtonEraser();
                    if (Form1.arrayLength != 0)
                        ButtonPrinter();
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
                ButtonEraser();
                ButtonPrinter();
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
                //AddButton();


                ButtonEraser();
                ButtonPrinter();
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
                
                ButtonEraser();
                ButtonPrinter();
            }
        }



        public void AddButton()
        {

            Button newButton = new Button();
            newButton.Location = new Point(fromLeft, fromTop);
            if (fromLeft < 610)
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
            Controls.Add(newButton);
        }     // не работает

        public void ButtonRewrite()
       {
            for (int i = 0; i < Form1.arrayLength; i++)
            {
                MessageBox.Show(Convert.ToString(i) + "   " + Convert.ToString(Form1.arrayLength),"");
                buttons[i].Text = Convert.ToString(Form1.arrayMain[i]);
            }
       } // что-то делает

        public void NewButton(int i, int j)
        {
            Button newButton = new Button();
            newButton.Location = new Point(fromLeft, fromTop);

            //newButton.Name = bName + Convert.ToString(nameint);
            buttons.Add(newButton); //
            newButton.Size = new Size(40, 20);
            newButton.TabIndex = tabindex;
            tabindex++;
            newButton.Click += ButtonOnClick;
            newButton.Text = Convert.ToString(Form1.arrayMain[i + j]);        //buttons.LastIndexOf(Button));        //Form1.arrayMain[IndexOf]);
            
            //for (int i = 0; i < Form1.arrayLength - 10; i += 10)
            //{
            //    fromLeft = 10;
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Button newButton = new Button();
            //        newButton.Location = new Point(fromLeft, fromTop);
            //        fromLeft += 60;

            //        newButton.Name = name + Convert.ToString(nameInt);
            //        buttons.Add(newButton);
            //        nameInt++;
            //        newButton.Size = new Size(40, 20);
            //        newButton.TabIndex = tabIndex;
            //        tabIndex++;
            //        newButton.Click += ButtonOnClick;
            //        newButton.Text = Convert.ToString(Form1.arrayMain[i + j]);
            //        Controls.Add(newButton);
            //    }
            //    fromTop += 40;
            } // не работает
        
        public void ButtonPrinterv2()
        {
            for (int i = 0; i < Form1.arrayLength - 10; i += 10)
            {
                for (int j = 0; j < 10; j++)
                {
                    NewButton(i, j);
                    fromLeft += 60;
                }
                fromLeft = 10;
                fromTop += 40;
            }
            if (Form1.arrayLength % 10 != 0)
                for (int j = Form1.arrayLength - Form1.arrayLength % 10; j < Form1.arrayLength; j++)
                {
                    NewButton(Form1.arrayLength - Form1.arrayLength % 10, j);
                    fromLeft += 60;
                }
            else
                for (int j = Form1.arrayLength - 10; j < Form1.arrayLength; j++)
                {
                    NewButton(Form1.arrayLength - 10, j);
                    fromLeft += 60;
                }
            ButtonRewrite();
        } //не работает

        public void ButtonSnipeEraser()
        {
            buttons[Form1.arrayLength - 1].Dispose();
            buttons.RemoveAt(Form1.arrayLength - 1);
            ButtonRewrite();
        } //не нужно без работы AddButton


    }
}