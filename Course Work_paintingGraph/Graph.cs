using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Course_Work_paintingGraph
{
    public class Graph
    {
        /// <summary>
        /// Конструктор нового екземпляру класу Graph
        /// </summary>
        public Graph() {
            vertex = new List<Tuple<string, PointF,Color>>();
            edge = new List<Tuple<string, string>>();
        }

        /// <summary>
        /// Конструктор нового екземпляру класу Graph на основі існуючого
        /// </summary>
        public Graph(List<Tuple<string, PointF, Color>> v, List<Tuple<string, string>>e)
        {
            vertex = new List<Tuple<string, PointF, Color>>();
            edge = new List<Tuple<string, string>>();

            foreach (Tuple<string, PointF, Color> val in v)
                vertex.Add(val);
            edge = e;
        }

        /// <summary>
        /// Поле зберігання харакетиристик вершин (назва, розташування, колір)
        /// </summary>
        public List<Tuple<string, PointF, Color>> vertex;

        /// <summary>
        /// Поле зберіганя характеристик ребер (назва початку та назва кінця)
        /// </summary>
        public List<Tuple<string, string>> edge;
    }
}
