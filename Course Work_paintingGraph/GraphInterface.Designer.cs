
namespace Course_Work_paintingGraph
{
    partial class GraphInterface
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.control1 = new System.Windows.Forms.GroupBox();
            this.MFI_Presentation1 = new System.Windows.Forms.Button();
            this.clear1Button = new System.Windows.Forms.Button();
            this.keyboardEnter1 = new System.Windows.Forms.Button();
            this.randGenerateGraph1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.control2 = new System.Windows.Forms.GroupBox();
            this.MFI_Presentation2 = new System.Windows.Forms.Button();
            this.clear2Button = new System.Windows.Forms.Button();
            this.keyboardEnter2 = new System.Windows.Forms.Button();
            this.randGenerateGraph2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.input1 = new System.Windows.Forms.PictureBox();
            this.input2 = new System.Windows.Forms.PictureBox();
            this.input1Matrix = new System.Windows.Forms.DataGridView();
            this.input2Matrix = new System.Windows.Forms.DataGridView();
            this.output1 = new System.Windows.Forms.PictureBox();
            this.output2 = new System.Windows.Forms.PictureBox();
            this.coloringGraph2Button = new System.Windows.Forms.Button();
            this.outputGB2 = new System.Windows.Forms.GroupBox();
            this.outputText2 = new System.Windows.Forms.TextBox();
            this.clearOutput2 = new System.Windows.Forms.Button();
            this.outputGB1 = new System.Windows.Forms.GroupBox();
            this.outputText1 = new System.Windows.Forms.TextBox();
            this.clearOutput1 = new System.Windows.Forms.Button();
            this.generalOutput = new System.Windows.Forms.TextBox();
            this.aboutProgram = new System.Windows.Forms.Button();
            this.coloringGraph1Button = new System.Windows.Forms.Button();
            this.control1.SuspendLayout();
            this.control2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output2)).BeginInit();
            this.outputGB2.SuspendLayout();
            this.outputGB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.Controls.Add(this.MFI_Presentation1);
            this.control1.Controls.Add(this.clear1Button);
            this.control1.Controls.Add(this.keyboardEnter1);
            this.control1.Controls.Add(this.randGenerateGraph1);
            this.control1.Controls.Add(this.radioButton2);
            this.control1.Controls.Add(this.radioButton1);
            this.control1.Location = new System.Drawing.Point(11, 25);
            this.control1.Margin = new System.Windows.Forms.Padding(2);
            this.control1.Name = "control1";
            this.control1.Padding = new System.Windows.Forms.Padding(2);
            this.control1.Size = new System.Drawing.Size(128, 391);
            this.control1.TabIndex = 0;
            this.control1.TabStop = false;
            this.control1.Text = "Контроль вводу";
            // 
            // MFI_Presentation1
            // 
            this.MFI_Presentation1.Location = new System.Drawing.Point(5, 299);
            this.MFI_Presentation1.Name = "MFI_Presentation1";
            this.MFI_Presentation1.Size = new System.Drawing.Size(117, 52);
            this.MFI_Presentation1.TabIndex = 9;
            this.MFI_Presentation1.Text = "MFI подання";
            this.MFI_Presentation1.UseVisualStyleBackColor = true;
            this.MFI_Presentation1.Click += new System.EventHandler(this.MFI_Presentation_Click);
            // 
            // clear1Button
            // 
            this.clear1Button.Location = new System.Drawing.Point(5, 234);
            this.clear1Button.Name = "clear1Button";
            this.clear1Button.Size = new System.Drawing.Size(117, 52);
            this.clear1Button.TabIndex = 8;
            this.clear1Button.Text = "Видалити введений граф";
            this.clear1Button.UseVisualStyleBackColor = true;
            this.clear1Button.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // keyboardEnter1
            // 
            this.keyboardEnter1.Location = new System.Drawing.Point(6, 102);
            this.keyboardEnter1.Name = "keyboardEnter1";
            this.keyboardEnter1.Size = new System.Drawing.Size(117, 62);
            this.keyboardEnter1.TabIndex = 7;
            this.keyboardEnter1.Text = "Ввести координати точки";
            this.keyboardEnter1.UseVisualStyleBackColor = true;
            this.keyboardEnter1.Click += new System.EventHandler(this.keyboardEnter_Click);
            // 
            // randGenerateGraph1
            // 
            this.randGenerateGraph1.Location = new System.Drawing.Point(5, 172);
            this.randGenerateGraph1.Name = "randGenerateGraph1";
            this.randGenerateGraph1.Size = new System.Drawing.Size(117, 52);
            this.randGenerateGraph1.TabIndex = 6;
            this.randGenerateGraph1.Text = "Випадкова генерація";
            this.randGenerateGraph1.UseVisualStyleBackColor = true;
            this.randGenerateGraph1.Click += new System.EventHandler(this.randGenerateGraph_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 62);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Видалення";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 35);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Додавання";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // control2
            // 
            this.control2.Controls.Add(this.MFI_Presentation2);
            this.control2.Controls.Add(this.clear2Button);
            this.control2.Controls.Add(this.keyboardEnter2);
            this.control2.Controls.Add(this.randGenerateGraph2);
            this.control2.Controls.Add(this.radioButton3);
            this.control2.Controls.Add(this.radioButton4);
            this.control2.Location = new System.Drawing.Point(1770, 23);
            this.control2.Margin = new System.Windows.Forms.Padding(2);
            this.control2.Name = "control2";
            this.control2.Padding = new System.Windows.Forms.Padding(2);
            this.control2.Size = new System.Drawing.Size(128, 393);
            this.control2.TabIndex = 1;
            this.control2.TabStop = false;
            this.control2.Text = "Контроль вводу";
            // 
            // MFI_Presentation2
            // 
            this.MFI_Presentation2.Location = new System.Drawing.Point(5, 302);
            this.MFI_Presentation2.Name = "MFI_Presentation2";
            this.MFI_Presentation2.Size = new System.Drawing.Size(117, 52);
            this.MFI_Presentation2.TabIndex = 15;
            this.MFI_Presentation2.Text = "MFI подання";
            this.MFI_Presentation2.UseVisualStyleBackColor = true;
            this.MFI_Presentation2.Click += new System.EventHandler(this.MFI_Presentation_Click);
            // 
            // clear2Button
            // 
            this.clear2Button.Location = new System.Drawing.Point(5, 237);
            this.clear2Button.Name = "clear2Button";
            this.clear2Button.Size = new System.Drawing.Size(117, 52);
            this.clear2Button.TabIndex = 14;
            this.clear2Button.Text = "Видалити введений граф";
            this.clear2Button.UseVisualStyleBackColor = true;
            this.clear2Button.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // keyboardEnter2
            // 
            this.keyboardEnter2.Location = new System.Drawing.Point(6, 105);
            this.keyboardEnter2.Name = "keyboardEnter2";
            this.keyboardEnter2.Size = new System.Drawing.Size(117, 62);
            this.keyboardEnter2.TabIndex = 13;
            this.keyboardEnter2.Text = "Ввести координати точки";
            this.keyboardEnter2.UseVisualStyleBackColor = true;
            this.keyboardEnter2.Click += new System.EventHandler(this.keyboardEnter_Click);
            // 
            // randGenerateGraph2
            // 
            this.randGenerateGraph2.Location = new System.Drawing.Point(5, 175);
            this.randGenerateGraph2.Name = "randGenerateGraph2";
            this.randGenerateGraph2.Size = new System.Drawing.Size(117, 52);
            this.randGenerateGraph2.TabIndex = 11;
            this.randGenerateGraph2.Text = "Випадкова генерація";
            this.randGenerateGraph2.UseVisualStyleBackColor = true;
            this.randGenerateGraph2.Click += new System.EventHandler(this.randGenerateGraph_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 21);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "Видалення";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 38);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 21);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Додавання";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input1.Location = new System.Drawing.Point(155, 23);
            this.input1.Margin = new System.Windows.Forms.Padding(2);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(350, 393);
            this.input1.TabIndex = 0;
            this.input1.TabStop = false;
            this.input1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            // 
            // input2
            // 
            this.input2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input2.Location = new System.Drawing.Point(1405, 25);
            this.input2.Margin = new System.Windows.Forms.Padding(2);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(350, 391);
            this.input2.TabIndex = 2;
            this.input2.TabStop = false;
            this.input2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            // 
            // input1Matrix
            // 
            this.input1Matrix.AllowUserToAddRows = false;
            this.input1Matrix.AllowUserToDeleteRows = false;
            this.input1Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.input1Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input1Matrix.Location = new System.Drawing.Point(509, 23);
            this.input1Matrix.Margin = new System.Windows.Forms.Padding(2);
            this.input1Matrix.Name = "input1Matrix";
            this.input1Matrix.RowHeadersWidth = 51;
            this.input1Matrix.RowTemplate.Height = 24;
            this.input1Matrix.Size = new System.Drawing.Size(435, 393);
            this.input1Matrix.TabIndex = 5;
            this.input1Matrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            this.input1Matrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            // 
            // input2Matrix
            // 
            this.input2Matrix.AllowUserToAddRows = false;
            this.input2Matrix.AllowUserToDeleteRows = false;
            this.input2Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.input2Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input2Matrix.Location = new System.Drawing.Point(966, 23);
            this.input2Matrix.Margin = new System.Windows.Forms.Padding(2);
            this.input2Matrix.Name = "input2Matrix";
            this.input2Matrix.RowHeadersWidth = 51;
            this.input2Matrix.RowTemplate.Height = 24;
            this.input2Matrix.Size = new System.Drawing.Size(435, 393);
            this.input2Matrix.TabIndex = 6;
            this.input2Matrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            this.input2Matrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            // 
            // output1
            // 
            this.output1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output1.Location = new System.Drawing.Point(330, 552);
            this.output1.Margin = new System.Windows.Forms.Padding(2);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(350, 374);
            this.output1.TabIndex = 7;
            this.output1.TabStop = false;
            // 
            // output2
            // 
            this.output2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output2.Location = new System.Drawing.Point(1230, 558);
            this.output2.Margin = new System.Windows.Forms.Padding(2);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(350, 368);
            this.output2.TabIndex = 8;
            this.output2.TabStop = false;
            // 
            // coloringGraph2Button
            // 
            this.coloringGraph2Button.Location = new System.Drawing.Point(1304, 453);
            this.coloringGraph2Button.Name = "coloringGraph2Button";
            this.coloringGraph2Button.Size = new System.Drawing.Size(199, 60);
            this.coloringGraph2Button.TabIndex = 10;
            this.coloringGraph2Button.Text = "Розфарбувати граф";
            this.coloringGraph2Button.UseVisualStyleBackColor = true;
            this.coloringGraph2Button.Click += new System.EventHandler(this.coloringGraphButton_Click);
            // 
            // outputGB2
            // 
            this.outputGB2.Controls.Add(this.outputText2);
            this.outputGB2.Location = new System.Drawing.Point(1601, 558);
            this.outputGB2.Name = "outputGB2";
            this.outputGB2.Size = new System.Drawing.Size(297, 284);
            this.outputGB2.TabIndex = 11;
            this.outputGB2.TabStop = false;
            this.outputGB2.Text = "Контроль виводу";
            // 
            // outputText2
            // 
            this.outputText2.BackColor = System.Drawing.SystemColors.Control;
            this.outputText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText2.Location = new System.Drawing.Point(24, 31);
            this.outputText2.Multiline = true;
            this.outputText2.Name = "outputText2";
            this.outputText2.ReadOnly = true;
            this.outputText2.Size = new System.Drawing.Size(254, 203);
            this.outputText2.TabIndex = 14;
            // 
            // clearOutput2
            // 
            this.clearOutput2.Location = new System.Drawing.Point(1624, 867);
            this.clearOutput2.Name = "clearOutput2";
            this.clearOutput2.Size = new System.Drawing.Size(254, 52);
            this.clearOutput2.TabIndex = 16;
            this.clearOutput2.Text = "Очищення виводу та перехід до введеня даних";
            this.clearOutput2.UseVisualStyleBackColor = true;
            this.clearOutput2.Click += new System.EventHandler(this.clearOutput_Click);
            // 
            // outputGB1
            // 
            this.outputGB1.Controls.Add(this.outputText1);
            this.outputGB1.Location = new System.Drawing.Point(11, 552);
            this.outputGB1.Name = "outputGB1";
            this.outputGB1.Size = new System.Drawing.Size(297, 290);
            this.outputGB1.TabIndex = 12;
            this.outputGB1.TabStop = false;
            this.outputGB1.Text = "Контроль виводу";
            // 
            // outputText1
            // 
            this.outputText1.BackColor = System.Drawing.SystemColors.Control;
            this.outputText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText1.Location = new System.Drawing.Point(22, 37);
            this.outputText1.Multiline = true;
            this.outputText1.Name = "outputText1";
            this.outputText1.ReadOnly = true;
            this.outputText1.Size = new System.Drawing.Size(254, 203);
            this.outputText1.TabIndex = 13;
            // 
            // clearOutput1
            // 
            this.clearOutput1.Location = new System.Drawing.Point(33, 867);
            this.clearOutput1.Name = "clearOutput1";
            this.clearOutput1.Size = new System.Drawing.Size(254, 52);
            this.clearOutput1.TabIndex = 15;
            this.clearOutput1.Text = "Очищення виводу та перехід до введеня даних";
            this.clearOutput1.UseVisualStyleBackColor = true;
            this.clearOutput1.Click += new System.EventHandler(this.clearOutput_Click);
            // 
            // generalOutput
            // 
            this.generalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.generalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalOutput.Location = new System.Drawing.Point(722, 616);
            this.generalOutput.Multiline = true;
            this.generalOutput.Name = "generalOutput";
            this.generalOutput.ReadOnly = true;
            this.generalOutput.Size = new System.Drawing.Size(476, 167);
            this.generalOutput.TabIndex = 17;
            this.generalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aboutProgram
            // 
            this.aboutProgram.Location = new System.Drawing.Point(879, 889);
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(150, 30);
            this.aboutProgram.TabIndex = 17;
            this.aboutProgram.Text = "Про програму";
            this.aboutProgram.UseVisualStyleBackColor = true;
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // coloringGraph1Button
            // 
            this.coloringGraph1Button.Location = new System.Drawing.Point(407, 453);
            this.coloringGraph1Button.Name = "coloringGraph1Button";
            this.coloringGraph1Button.Size = new System.Drawing.Size(199, 60);
            this.coloringGraph1Button.TabIndex = 9;
            this.coloringGraph1Button.Text = "Розфарбувати граф";
            this.coloringGraph1Button.UseVisualStyleBackColor = true;
            this.coloringGraph1Button.Click += new System.EventHandler(this.coloringGraphButton_Click);
            // 
            // GraphInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1906, 1014);
            this.Controls.Add(this.clearOutput2);
            this.Controls.Add(this.clearOutput1);
            this.Controls.Add(this.coloringGraph1Button);
            this.Controls.Add(this.aboutProgram);
            this.Controls.Add(this.generalOutput);
            this.Controls.Add(this.outputGB1);
            this.Controls.Add(this.outputGB2);
            this.Controls.Add(this.coloringGraph2Button);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.input2Matrix);
            this.Controls.Add(this.input1Matrix);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.control2);
            this.Controls.Add(this.control1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GraphInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Розмальовуванная графа";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.control1.ResumeLayout(false);
            this.control1.PerformLayout();
            this.control2.ResumeLayout(false);
            this.control2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output2)).EndInit();
            this.outputGB2.ResumeLayout(false);
            this.outputGB2.PerformLayout();
            this.outputGB1.ResumeLayout(false);
            this.outputGB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox control1;
        private System.Windows.Forms.GroupBox control2;
        private System.Windows.Forms.PictureBox input1;
        private System.Windows.Forms.PictureBox input2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView input1Matrix;
        private System.Windows.Forms.Button keyboardEnter1;
        private System.Windows.Forms.Button randGenerateGraph1;
        private System.Windows.Forms.Button clear1Button;
        private System.Windows.Forms.Button MFI_Presentation1;
        private System.Windows.Forms.Button MFI_Presentation2;
        private System.Windows.Forms.Button clear2Button;
        private System.Windows.Forms.Button keyboardEnter2;
        private System.Windows.Forms.Button randGenerateGraph2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView input2Matrix;
        private System.Windows.Forms.PictureBox output1;
        private System.Windows.Forms.PictureBox output2;
        private System.Windows.Forms.Button coloringGraph2Button;
        private System.Windows.Forms.GroupBox outputGB2;
        private System.Windows.Forms.Button clearOutput2;
        private System.Windows.Forms.TextBox outputText2;
        private System.Windows.Forms.GroupBox outputGB1;
        private System.Windows.Forms.Button clearOutput1;
        private System.Windows.Forms.TextBox outputText1;
        private System.Windows.Forms.TextBox generalOutput;
        private System.Windows.Forms.Button aboutProgram;
        private System.Windows.Forms.Button coloringGraph1Button;
    }
}

