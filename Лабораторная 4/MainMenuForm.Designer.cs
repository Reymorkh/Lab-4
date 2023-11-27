namespace Лабораторная_4
{
  partial class MainMenuForm
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
      MainButton = new Button();
      MainWindow = new TextBox();
      RandomFiller = new Button();
      MinusButton = new Button();
      PlusButton = new Button();
      label1 = new Label();
      label2 = new Label();
      NullRandom = new Button();
      EvenSearchButton = new Button();
      EvenSearchLabel = new Label();
      ReverseButton = new Button();
      SortButton = new Button();
      ArrayEnterButton = new Button();
      BinarySearchButton = new Button();
      BinarySearchBox = new TextBox();
      BinarySearchLabel = new Label();
      SuspendLayout();
      // 
      // PlaceSwapper
      // 
      PlaceSwapper.Location = new Point(583, 319);
      PlaceSwapper.Name = "PlaceSwapper";
      PlaceSwapper.Size = new Size(126, 69);
      PlaceSwapper.TabIndex = 0;
      PlaceSwapper.Text = "Добавление Удаление Перестановка элементов";
      PlaceSwapper.UseVisualStyleBackColor = true;
      PlaceSwapper.Click += PlaceSwapper_Click;
      // 
      // textBox1
      // 
      textBox1.AllowDrop = true;
      textBox1.ForeColor = SystemColors.GrayText;
      textBox1.Location = new Point(12, 427);
      textBox1.MaxLength = 5;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(507, 23);
      textBox1.TabIndex = 1;
      textBox1.Text = "Поле ввода";
      textBox1.Enter += textBox1_Enter;
      textBox1.KeyDown += TextBox1_KeyDown;
      textBox1.Leave += textBox1_Leave;
      // 
      // MainButton
      // 
      MainButton.Location = new Point(528, 427);
      MainButton.Name = "MainButton";
      MainButton.Size = new Size(75, 23);
      MainButton.TabIndex = 2;
      MainButton.Text = "Enter";
      MainButton.UseVisualStyleBackColor = true;
      MainButton.Click += EnterButton_Click;
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
      // 
      // RandomFiller
      // 
      RandomFiller.Location = new Point(583, 50);
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
      NullRandom.Location = new Point(583, 79);
      NullRandom.Name = "NullRandom";
      NullRandom.Size = new Size(126, 23);
      NullRandom.TabIndex = 12;
      NullRandom.Text = "Заполнить новые";
      NullRandom.UseVisualStyleBackColor = true;
      NullRandom.Click += FillNewRandom_Click;
      // 
      // EvenSearchButton
      // 
      EvenSearchButton.Location = new Point(583, 234);
      EvenSearchButton.Name = "EvenSearchButton";
      EvenSearchButton.Size = new Size(123, 23);
      EvenSearchButton.TabIndex = 13;
      EvenSearchButton.Text = "Поиск чётного";
      EvenSearchButton.UseVisualStyleBackColor = true;
      EvenSearchButton.Visible = false;
      EvenSearchButton.Click += SearchButton_Click;
      // 
      // EvenSearchLabel
      // 
      EvenSearchLabel.AutoSize = true;
      EvenSearchLabel.Location = new Point(534, 275);
      EvenSearchLabel.Name = "EvenSearchLabel";
      EvenSearchLabel.Size = new Size(156, 15);
      EvenSearchLabel.TabIndex = 14;
      EvenSearchLabel.Text = "Поиск пока не проводился";
      EvenSearchLabel.Visible = false;
      // 
      // ReverseButton
      // 
      ReverseButton.Location = new Point(583, 108);
      ReverseButton.Name = "ReverseButton";
      ReverseButton.Size = new Size(126, 23);
      ReverseButton.TabIndex = 15;
      ReverseButton.Text = "Переворот массива";
      ReverseButton.UseVisualStyleBackColor = true;
      ReverseButton.Click += ReverseButton_Click;
      // 
      // SortButton
      // 
      SortButton.Location = new Point(583, 137);
      SortButton.Name = "SortButton";
      SortButton.Size = new Size(126, 23);
      SortButton.TabIndex = 16;
      SortButton.Text = "Сорт";
      SortButton.UseVisualStyleBackColor = true;
      SortButton.Click += SortButton_Click;
      // 
      // ArrayEnterButton
      // 
      ArrayEnterButton.Location = new Point(583, 21);
      ArrayEnterButton.Name = "ArrayEnterButton";
      ArrayEnterButton.Size = new Size(123, 23);
      ArrayEnterButton.TabIndex = 17;
      ArrayEnterButton.Text = "Вручную";
      ArrayEnterButton.UseVisualStyleBackColor = true;
      ArrayEnterButton.Click += ArrayRewriteButton_Click;
      // 
      // BinarySearchButton
      // 
      BinarySearchButton.Location = new Point(583, 166);
      BinarySearchButton.Name = "BinarySearchButton";
      BinarySearchButton.Size = new Size(126, 23);
      BinarySearchButton.TabIndex = 18;
      BinarySearchButton.Text = "Поиск";
      BinarySearchButton.UseVisualStyleBackColor = true;
      BinarySearchButton.Visible = false;
      BinarySearchButton.Click += BinarySearchButton_Click;
      // 
      // BinarySearchBox
      // 
      BinarySearchBox.Location = new Point(534, 166);
      BinarySearchBox.MaxLength = 4;
      BinarySearchBox.Name = "BinarySearchBox";
      BinarySearchBox.Size = new Size(43, 23);
      BinarySearchBox.TabIndex = 19;
      BinarySearchBox.Visible = false;
      // 
      // BinarySearchLabel
      // 
      BinarySearchLabel.AutoSize = true;
      BinarySearchLabel.Location = new Point(534, 205);
      BinarySearchLabel.Name = "BinarySearchLabel";
      BinarySearchLabel.Size = new Size(156, 15);
      BinarySearchLabel.TabIndex = 20;
      BinarySearchLabel.Text = "Поиск пока не проводился";
      BinarySearchLabel.Visible = false;
      // 
      // MainMenuForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackgroundImageLayout = ImageLayout.Center;
      ClientSize = new Size(755, 483);
      Controls.Add(BinarySearchLabel);
      Controls.Add(BinarySearchBox);
      Controls.Add(BinarySearchButton);
      Controls.Add(ArrayEnterButton);
      Controls.Add(SortButton);
      Controls.Add(ReverseButton);
      Controls.Add(EvenSearchLabel);
      Controls.Add(EvenSearchButton);
      Controls.Add(NullRandom);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(PlusButton);
      Controls.Add(MinusButton);
      Controls.Add(RandomFiller);
      Controls.Add(MainWindow);
      Controls.Add(MainButton);
      Controls.Add(PlaceSwapper);
      Controls.Add(textBox1);
      Name = "MainMenuForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Лабораторная работа №4";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Button PlaceSwapper;
    private TextBox textBox1;
    private Button MainButton;
    private TextBox MainWindow;
    private Button RandomFiller;
    private Button MinusButton;
    private Button PlusButton;
    private Label label1;
    private Label label2;
    private Button NullRandom;
    private Button EvenSearchButton;
    private Label EvenSearchLabel;
    private Button ReverseButton;
    private Button SortButton;
    private Button ArrayEnterButton;
    private TextBox BinarySearchBox;
    private Button BinarySearchButton;
    private Label BinarySearchLabel;
  }
}