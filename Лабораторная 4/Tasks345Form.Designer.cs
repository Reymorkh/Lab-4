namespace Лабораторная_4
{
  partial class Tasks345Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      textBox1 = new TextBox();
      addButton = new Button();
      guideButton = new Button();
      deleteButton = new Button();
      AddMax = new Button();
      DelMax = new Button();
      Addx = new Button();
      SwapModeCheckbox = new CheckBox();
      SuspendLayout();
      // 
      // textBox1
      // 
      textBox1.Location = new Point(10, 20);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(100, 23);
      textBox1.TabIndex = 0;
      // 
      // addButton
      // 
      addButton.Location = new Point(192, 20);
      addButton.Name = "addButton";
      addButton.Size = new Size(68, 23);
      addButton.TabIndex = 1;
      addButton.Text = "AddEnd";
      addButton.UseVisualStyleBackColor = true;
      addButton.Click += AddButton_Click;
      // 
      // guideButton
      // 
      guideButton.Location = new Point(496, 20);
      guideButton.Name = "guideButton";
      guideButton.Size = new Size(23, 23);
      guideButton.TabIndex = 2;
      guideButton.Text = "?";
      guideButton.UseVisualStyleBackColor = true;
      guideButton.Click += GuideButton_Click;
      // 
      // deleteButton
      // 
      deleteButton.Location = new Point(115, 49);
      deleteButton.Name = "deleteButton";
      deleteButton.Size = new Size(69, 23);
      deleteButton.TabIndex = 3;
      deleteButton.Text = "Del";
      deleteButton.UseVisualStyleBackColor = true;
      deleteButton.Click += DeleteButton_Click;
      // 
      // AddMax
      // 
      AddMax.Location = new Point(116, 20);
      AddMax.Name = "AddMax";
      AddMax.Size = new Size(70, 23);
      AddMax.TabIndex = 4;
      AddMax.Text = "AddStart";
      AddMax.UseVisualStyleBackColor = true;
      AddMax.Click += AddStart_Click;
      // 
      // DelMax
      // 
      DelMax.Location = new Point(190, 49);
      DelMax.Name = "DelMax";
      DelMax.Size = new Size(70, 23);
      DelMax.TabIndex = 5;
      DelMax.Text = "DelMax";
      DelMax.UseVisualStyleBackColor = true;
      DelMax.Click += DelMax_Click;
      // 
      // Addx
      // 
      Addx.Location = new Point(266, 20);
      Addx.Name = "Addx";
      Addx.Size = new Size(75, 23);
      Addx.TabIndex = 6;
      Addx.Text = "AddX";
      Addx.UseVisualStyleBackColor = true;
      Addx.Click += Addx_Click;
      // 
      // SwapModeCheckbox
      // 
      SwapModeCheckbox.AutoSize = true;
      SwapModeCheckbox.Location = new Point(347, 20);
      SwapModeCheckbox.Name = "SwapModeCheckbox";
      SwapModeCheckbox.Size = new Size(143, 19);
      SwapModeCheckbox.TabIndex = 7;
      SwapModeCheckbox.Text = "Режим перестановки";
      SwapModeCheckbox.UseVisualStyleBackColor = true;
      SwapModeCheckbox.CheckedChanged += SwapModeCheckbox_CheckedChanged;
      // 
      // Tasks345Form
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      BackgroundImageLayout = ImageLayout.Center;
      ClientSize = new Size(608, 450);
      Controls.Add(SwapModeCheckbox);
      Controls.Add(Addx);
      Controls.Add(DelMax);
      Controls.Add(AddMax);
      Controls.Add(deleteButton);
      Controls.Add(guideButton);
      Controls.Add(addButton);
      Controls.Add(textBox1);
      DoubleBuffered = true;
      Name = "Tasks345Form";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Самая крутая форма";
      Load += Form2_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Button addButton;
    private Button guideButton;
    private Button deleteButton;
    private Button AddMax;
    private Button DelMax;
    private Button Addx;
    private CheckBox SwapModeCheckbox;
  }
}