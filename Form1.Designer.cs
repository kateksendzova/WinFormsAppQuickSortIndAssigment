namespace WinFormsAppQuickSortIndAssigment
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
            label_infoSize = new Label();
            numericUpDown_Size = new NumericUpDown();
            textBox_GeneratedArray = new TextBox();
            label_infoGeneratedArray = new Label();
            richTextBox_StepsOfSorting = new RichTextBox();
            label_infoSteps = new Label();
            textBox_SortedArray = new TextBox();
            label_infoSortedArray = new Label();
            button_Clear = new Button();
            button_GenerateArray = new Button();
            button_Sort = new Button();
            label_infoTime = new Label();
            textBox_Time = new TextBox();
            textBox_ArrayWithoutModa = new TextBox();
            label_infoArrayWithoutModa = new Label();
            textBox_Moda = new TextBox();
            label_infoModa = new Label();
            button_DeleteModa = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).BeginInit();
            SuspendLayout();
            // 
            // label_infoSize
            // 
            label_infoSize.AutoSize = true;
            label_infoSize.Location = new Point(41, 25);
            label_infoSize.Name = "label_infoSize";
            label_infoSize.Size = new Size(167, 20);
            label_infoSize.TabIndex = 0;
            label_infoSize.Text = "Введіть розмір масиву";
            // 
            // numericUpDown_Size
            // 
            numericUpDown_Size.Location = new Point(214, 25);
            numericUpDown_Size.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_Size.Name = "numericUpDown_Size";
            numericUpDown_Size.Size = new Size(58, 27);
            numericUpDown_Size.TabIndex = 1;
            numericUpDown_Size.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBox_GeneratedArray
            // 
            textBox_GeneratedArray.Location = new Point(12, 117);
            textBox_GeneratedArray.Name = "textBox_GeneratedArray";
            textBox_GeneratedArray.Size = new Size(443, 27);
            textBox_GeneratedArray.TabIndex = 2;
            // 
            // label_infoGeneratedArray
            // 
            label_infoGeneratedArray.AutoSize = true;
            label_infoGeneratedArray.Location = new Point(178, 94);
            label_infoGeneratedArray.Name = "label_infoGeneratedArray";
            label_infoGeneratedArray.Size = new Size(140, 20);
            label_infoGeneratedArray.TabIndex = 3;
            label_infoGeneratedArray.Text = "Початковий масив";
            // 
            // richTextBox_StepsOfSorting
            // 
            richTextBox_StepsOfSorting.Location = new Point(467, 85);
            richTextBox_StepsOfSorting.Name = "richTextBox_StepsOfSorting";
            richTextBox_StepsOfSorting.Size = new Size(522, 429);
            richTextBox_StepsOfSorting.TabIndex = 4;
            richTextBox_StepsOfSorting.Text = "";
            // 
            // label_infoSteps
            // 
            label_infoSteps.AutoSize = true;
            label_infoSteps.Location = new Point(675, 62);
            label_infoSteps.Name = "label_infoSteps";
            label_infoSteps.Size = new Size(136, 20);
            label_infoSteps.TabIndex = 5;
            label_infoSteps.Text = "Кроки сортування";
            // 
            // textBox_SortedArray
            // 
            textBox_SortedArray.Location = new Point(12, 417);
            textBox_SortedArray.Name = "textBox_SortedArray";
            textBox_SortedArray.Size = new Size(443, 27);
            textBox_SortedArray.TabIndex = 6;
            // 
            // label_infoSortedArray
            // 
            label_infoSortedArray.AutoSize = true;
            label_infoSortedArray.BackColor = SystemColors.Info;
            label_infoSortedArray.Location = new Point(159, 394);
            label_infoSortedArray.Name = "label_infoSortedArray";
            label_infoSortedArray.Size = new Size(159, 20);
            label_infoSortedArray.TabIndex = 7;
            label_infoSortedArray.Text = "Посортований масив";
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(895, 529);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 29);
            button_Clear.TabIndex = 8;
            button_Clear.Text = "Очистити";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_GenerateArray
            // 
            button_GenerateArray.BackColor = SystemColors.ActiveCaption;
            button_GenerateArray.Location = new Point(339, 25);
            button_GenerateArray.Name = "button_GenerateArray";
            button_GenerateArray.Size = new Size(116, 49);
            button_GenerateArray.TabIndex = 9;
            button_GenerateArray.Text = "Згенерувати масив";
            button_GenerateArray.UseVisualStyleBackColor = false;
            button_GenerateArray.Click += button_GenerateArray_Click;
            // 
            // button_Sort
            // 
            button_Sort.BackColor = SystemColors.GradientActiveCaption;
            button_Sort.Location = new Point(339, 319);
            button_Sort.Name = "button_Sort";
            button_Sort.Size = new Size(116, 49);
            button_Sort.TabIndex = 10;
            button_Sort.Text = "Сортувати";
            button_Sort.UseVisualStyleBackColor = false;
            button_Sort.Click += button_Sort_Click;
            // 
            // label_infoTime
            // 
            label_infoTime.AutoSize = true;
            label_infoTime.Location = new Point(120, 484);
            label_infoTime.Name = "label_infoTime";
            label_infoTime.Size = new Size(118, 20);
            label_infoTime.TabIndex = 11;
            label_infoTime.Text = "Час сортування";
            // 
            // textBox_Time
            // 
            textBox_Time.Location = new Point(240, 480);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(195, 27);
            textBox_Time.TabIndex = 12;
            // 
            // textBox_ArrayWithoutModa
            // 
            textBox_ArrayWithoutModa.Location = new Point(12, 288);
            textBox_ArrayWithoutModa.Name = "textBox_ArrayWithoutModa";
            textBox_ArrayWithoutModa.Size = new Size(443, 27);
            textBox_ArrayWithoutModa.TabIndex = 13;
            // 
            // label_infoArrayWithoutModa
            // 
            label_infoArrayWithoutModa.AutoSize = true;
            label_infoArrayWithoutModa.Location = new Point(179, 265);
            label_infoArrayWithoutModa.Name = "label_infoArrayWithoutModa";
            label_infoArrayWithoutModa.Size = new Size(123, 20);
            label_infoArrayWithoutModa.TabIndex = 14;
            label_infoArrayWithoutModa.Text = "Масив без моди";
            // 
            // textBox_Moda
            // 
            textBox_Moda.Location = new Point(63, 161);
            textBox_Moda.Name = "textBox_Moda";
            textBox_Moda.Size = new Size(392, 27);
            textBox_Moda.TabIndex = 15;
            // 
            // label_infoModa
            // 
            label_infoModa.AutoSize = true;
            label_infoModa.Location = new Point(20, 164);
            label_infoModa.Name = "label_infoModa";
            label_infoModa.Size = new Size(47, 20);
            label_infoModa.TabIndex = 16;
            label_infoModa.Text = "Мода";
            // 
            // button_DeleteModa
            // 
            button_DeleteModa.Location = new Point(361, 204);
            button_DeleteModa.Name = "button_DeleteModa";
            button_DeleteModa.Size = new Size(94, 49);
            button_DeleteModa.TabIndex = 17;
            button_DeleteModa.Text = "Видалити моду";
            button_DeleteModa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 576);
            Controls.Add(button_DeleteModa);
            Controls.Add(label_infoModa);
            Controls.Add(textBox_Moda);
            Controls.Add(label_infoArrayWithoutModa);
            Controls.Add(textBox_ArrayWithoutModa);
            Controls.Add(textBox_Time);
            Controls.Add(label_infoTime);
            Controls.Add(button_Sort);
            Controls.Add(button_GenerateArray);
            Controls.Add(button_Clear);
            Controls.Add(label_infoSortedArray);
            Controls.Add(textBox_SortedArray);
            Controls.Add(label_infoSteps);
            Controls.Add(richTextBox_StepsOfSorting);
            Controls.Add(label_infoGeneratedArray);
            Controls.Add(textBox_GeneratedArray);
            Controls.Add(numericUpDown_Size);
            Controls.Add(label_infoSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_infoSize;
        private NumericUpDown numericUpDown_Size;
        private TextBox textBox_GeneratedArray;
        private Label label_infoGeneratedArray;
        private RichTextBox richTextBox_StepsOfSorting;
        private Label label_infoSteps;
        private TextBox textBox_SortedArray;
        private Label label_infoSortedArray;
        private Button button_Clear;
        private Button button_GenerateArray;
        private Button button_Sort;
        private Label label_infoTime;
        private TextBox textBox_Time;
        private TextBox textBox_ArrayWithoutModa;
        private Label label_infoArrayWithoutModa;
        private TextBox textBox_Moda;
        private Label label_infoModa;
        private Button button_DeleteModa;
    }
}
