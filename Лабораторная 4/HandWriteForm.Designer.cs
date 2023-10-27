namespace Лабораторная_4
{
  partial class HandWriteForm
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
      EnterButton = new Button();
      SkipButton = new Button();
      textBox1 = new TextBox();
      MainWindow = new TextBox();
      SuspendLayout();
      // 
      // EnterButton
      // 
      EnterButton.Location = new Point(213, 235);
      EnterButton.Name = "EnterButton";
      EnterButton.Size = new Size(75, 23);
      EnterButton.TabIndex = 0;
      EnterButton.Text = "Ввести";
      EnterButton.UseVisualStyleBackColor = true;
      EnterButton.Click += EnterButton_Click;
      // 
      // SkipButton
      // 
      SkipButton.Location = new Point(294, 235);
      SkipButton.Name = "SkipButton";
      SkipButton.Size = new Size(82, 23);
      SkipButton.TabIndex = 1;
      SkipButton.Text = "Пропустить";
      SkipButton.UseVisualStyleBackColor = true;
      SkipButton.Click += SkipButton_Click;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(12, 235);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(195, 23);
      textBox1.TabIndex = 2;
      // 
      // MainWindow
      // 
      MainWindow.Location = new Point(12, 12);
      MainWindow.Multiline = true;
      MainWindow.Name = "MainWindow";
      MainWindow.ReadOnly = true;
      MainWindow.Size = new Size(348, 172);
      MainWindow.TabIndex = 4;
      MainWindow.Text = "Вам осталось ввести x элементов";
      // 
      // HandWriteForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(384, 293);
      Controls.Add(MainWindow);
      Controls.Add(textBox1);
      Controls.Add(SkipButton);
      Controls.Add(EnterButton);
      Name = "HandWriteForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form4";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button EnterButton;
    private Button SkipButton;
    private TextBox textBox1;
    private TextBox MainWindow;
  }
}