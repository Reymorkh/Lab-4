namespace Лабораторная_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlaceSwapper = new Button();
            textBox1 = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            MainButton = new Button();
            MainWindow = new TextBox();
            RandomFiller = new Button();
            MinusButton = new Button();
            PlusButton = new Button();
            label1 = new Label();
            coolLabel = new Label();
            label2 = new Label();
            NullRandom = new Button();
            SearchButton = new Button();
            SearchOut = new Label();
            ReverseButton = new Button();
            SortButton = new Button();
            ArrayEnterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // PlaceSwapper
            // 
            PlaceSwapper.Location = new Point(645, 427);
            PlaceSwapper.Name = "PlaceSwapper";
            PlaceSwapper.Size = new Size(126, 23);
            PlaceSwapper.TabIndex = 0;
            PlaceSwapper.Text = "Переход 3,4,5";
            PlaceSwapper.UseVisualStyleBackColor = true;
            PlaceSwapper.Click += PlaceSwapper_Click;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(12, 427);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Поле ввода";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Leave += textBox1_Leave;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainButton
            // 
            MainButton.Location = new Point(528, 427);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(75, 23);
            MainButton.TabIndex = 2;
            MainButton.Text = "Enter";
            MainButton.UseVisualStyleBackColor = true;
            MainButton.Click += MainButton_Click;
            // 
            // MainWindow
            // 
            MainWindow.BackColor = SystemColors.ButtonHighlight;
            MainWindow.Location = new Point(12, 21);
            MainWindow.Multiline = true;
            MainWindow.Name = "MainWindow";
            MainWindow.ReadOnly = true;
            MainWindow.ScrollBars = ScrollBars.Vertical;
            MainWindow.Size = new Size(507, 335);
            MainWindow.TabIndex = 3;
            MainWindow.Text = "Здесь будет распечатан массив";
            MainWindow.TextChanged += MainWindow_TextChanged;
            // 
            // RandomFiller
            // 
            RandomFiller.Location = new Point(645, 50);
            RandomFiller.Name = "RandomFiller";
            RandomFiller.Size = new Size(126, 23);
            RandomFiller.TabIndex = 4;
            RandomFiller.Text = "Заполнить массив";
            RandomFiller.UseVisualStyleBackColor = true;
            RandomFiller.Click += RandomFiller_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(528, 456);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(35, 23);
            MinusButton.TabIndex = 6;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(568, 456);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(35, 23);
            PlusButton.TabIndex = 7;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 373);
            label1.Name = "label1";
            label1.Size = new Size(448, 15);
            label1.TabIndex = 9;
            label1.Text = "Кнопка Enter приравнивает длину последовательности к указанному значению.";
            label1.Click += label1_Click;
            // 
            // coolLabel
            // 
            coolLabel.AutoSize = true;
            coolLabel.Location = new Point(645, 406);
            coolLabel.Name = "coolLabel";
            coolLabel.Size = new Size(123, 15);
            coolLabel.TabIndex = 10;
            coolLabel.Text = "Самая крутая кнопка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 400);
            label2.Name = "label2";
            label2.Size = new Size(342, 15);
            label2.TabIndex = 11;
            label2.Text = "Кнопки +/- добавляют указанное значение к длине массива.";
            // 
            // NullRandom
            // 
            NullRandom.Location = new Point(645, 79);
            NullRandom.Name = "NullRandom";
            NullRandom.Size = new Size(126, 23);
            NullRandom.TabIndex = 12;
            NullRandom.Text = "Заполнить новые";
            NullRandom.UseVisualStyleBackColor = true;
            NullRandom.Click += NullRandom_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(528, 398);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 13;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Visible = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchOut
            // 
            SearchOut.AutoSize = true;
            SearchOut.Location = new Point(360, 402);
            SearchOut.Name = "SearchOut";
            SearchOut.Size = new Size(96, 15);
            SearchOut.TabIndex = 14;
            SearchOut.Text = "Нажмите Search";
            SearchOut.Visible = false;
            // 
            // ReverseButton
            // 
            ReverseButton.Location = new Point(645, 108);
            ReverseButton.Name = "ReverseButton";
            ReverseButton.Size = new Size(126, 23);
            ReverseButton.TabIndex = 15;
            ReverseButton.Text = "Переворот массива";
            ReverseButton.UseVisualStyleBackColor = true;
            ReverseButton.Click += ReverseButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(645, 137);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(126, 23);
            SortButton.TabIndex = 16;
            SortButton.Text = "Сорт";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // ArrayEnterButton
            // 
            ArrayEnterButton.Location = new Point(645, 21);
            ArrayEnterButton.Name = "ArrayEnterButton";
            ArrayEnterButton.Size = new Size(123, 23);
            ArrayEnterButton.TabIndex = 17;
            ArrayEnterButton.Text = "Вручную";
            ArrayEnterButton.UseVisualStyleBackColor = true;
            ArrayEnterButton.Click += ArrayEnterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(781, 483);
            Controls.Add(ArrayEnterButton);
            Controls.Add(SortButton);
            Controls.Add(ReverseButton);
            Controls.Add(SearchOut);
            Controls.Add(SearchButton);
            Controls.Add(NullRandom);
            Controls.Add(label2);
            Controls.Add(coolLabel);
            Controls.Add(label1);
            Controls.Add(PlusButton);
            Controls.Add(MinusButton);
            Controls.Add(RandomFiller);
            Controls.Add(MainWindow);
            Controls.Add(MainButton);
            Controls.Add(PlaceSwapper);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа №4";
            Load += Form1_Load;
            Enter += Form1_Enter;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PlaceSwapper;
        private TextBox textBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button MainButton;
        private TextBox MainWindow;
        private Button RandomFiller;
        private Button MinusButton;
        private Button PlusButton;
        private Label label1;
        private Label coolLabel;
        private Label label2;
        private Button NullRandom;
        private Button SearchButton;
        private Label SearchOut;
        private Button ReverseButton;
        private Button SortButton;
        private Button ArrayEnterButton;
    }
}