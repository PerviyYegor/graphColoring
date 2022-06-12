
namespace Course_Work_paintingGraph
{
    partial class childInputForm
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
            this.val1Field = new System.Windows.Forms.NumericUpDown();
            this.val2Field = new System.Windows.Forms.NumericUpDown();
            this.returnButton = new System.Windows.Forms.Button();
            this.val1Label = new System.Windows.Forms.Label();
            this.val2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.val1Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.val2Field)).BeginInit();
            this.SuspendLayout();
            // 
            // val1Field
            // 
            this.val1Field.Location = new System.Drawing.Point(12, 46);
            this.val1Field.Name = "val1Field";
            this.val1Field.Size = new System.Drawing.Size(125, 22);
            this.val1Field.TabIndex = 0;
            this.val1Field.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // val2Field
            // 
            this.val2Field.Location = new System.Drawing.Point(12, 115);
            this.val2Field.Name = "val2Field";
            this.val2Field.Size = new System.Drawing.Size(125, 22);
            this.val2Field.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(307, 174);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "OK";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // val1Label
            // 
            this.val1Label.AutoSize = true;
            this.val1Label.Location = new System.Drawing.Point(9, 26);
            this.val1Label.Name = "val1Label";
            this.val1Label.Size = new System.Drawing.Size(46, 17);
            this.val1Label.TabIndex = 3;
            this.val1Label.Text = "label1";
            // 
            // val2Label
            // 
            this.val2Label.AutoSize = true;
            this.val2Label.Location = new System.Drawing.Point(9, 95);
            this.val2Label.Name = "val2Label";
            this.val2Label.Size = new System.Drawing.Size(46, 17);
            this.val2Label.TabIndex = 4;
            this.val2Label.Text = "label2";
            // 
            // childInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 209);
            this.Controls.Add(this.val2Label);
            this.Controls.Add(this.val1Label);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.val2Field);
            this.Controls.Add(this.val1Field);
            this.Name = "childInputForm";
            this.Text = "Введіть дані";
            ((System.ComponentModel.ISupportInitialize)(this.val1Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.val2Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown val1Field;
        private System.Windows.Forms.NumericUpDown val2Field;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label val1Label;
        private System.Windows.Forms.Label val2Label;
    }
}