using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_paintingGraph
{
    public partial class childInputForm:Form
    {
        /// <summary>
        /// Поле, що зберігає значення з val1Field
        /// </summary>
        public int val1 = 0;
        /// <summary>
        /// Поле, що зберігає значення з val2Field
        /// </summary>
        public int val2 = 0;

        /// <summary>
        /// Поле зберігання максимальної кількості ребер
        /// </summary>
        int maxForEdges;

        /// <summary>
        /// Конструктор, що будує форму, в яку буде введені координати вершини, що має бути створено, або виділена
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="text2"></param>
        /// <param name="min2"></param>
        /// <param name="max2"></param>
        public childInputForm(string text1, int min1, int max1, string text2, int min2, int max2)
        {
            InitializeComponent();
            val1Field.ValueChanged -= numericUpDown1_ValueChanged;
            val1Field.Minimum = min1;
            val1Field.Maximum = max1;
            val2Field.Minimum = min2;
            val2Field.Maximum = max2;
            val1Label.Text = text1;
            val2Label.Text = text2;
        }

        /// <summary>
        /// Конструктор, що будує форму, в яку буде введено кількість вершин та кількість ребер графа, який буде створено
        /// </summary>
        /// <param name="max2"></param>
        /// <param name="text1"></param>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="text2"></param>
        /// <param name="min2"></param>
        public childInputForm(int max2, string text1, int min1, int max1, string text2, int min2)
        {
            InitializeComponent();
            maxForEdges = max2;
            val1Field.Minimum = min1;
            val1Field.Maximum = max1;
            val2Field.Minimum = min2;

            val1Label.Text = text1;
            val2Label.Text = text2;
        }

        /// <summary>
        /// Обробник подій виходу з форми childInputForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            val1 = (int)val1Field.Value;
            val2 = (int)val2Field.Value;
            this.Close();
        }

        /// <summary>
        /// Обробник подій зміни значення поля val1Field, що змінює максимум, що буде введено в поле val2Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (val1Field.Value * (val1Field.Value - 1) < maxForEdges)
                val2Field.Maximum = val1Field.Value * (val1Field.Value - 1);
            else val2Field.Maximum = maxForEdges;
            val2Label.Text = $"Введіть кількість ребер (max = {val2Field.Maximum})";
        }
    }
}
