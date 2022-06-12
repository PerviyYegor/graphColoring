using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Course_Work_paintingGraph
{
    static public class Logic
    {
        /// <summary>
        /// Введення вершин у граф та його відмальовування
        /// </summary>
        /// <param name="g"></param> 
        /// <param name="p"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="num"></param>
        /// <param name="graph"></param>
        /// <param name="vertNumMax"></param>
        /// <param name="VertexColor"></param>
        /// <returns></returns>
        static public bool EnterGraphVertex(ref Graphics g, PointF p, float LAngleDist, ref int num, ref Graph graph, int vertNumMax, Color VertexColor) {
            if (graph.vertex.Count < vertNumMax) 
            {
                p = new PointF(p.X,p.Y);
                for (int i = 0; i < graph.vertex.Count; i++)
                    if (graph.vertex[i].Item2.X < p.X + LAngleDist / (float)0.707 && graph.vertex[i].Item2.X > p.X - LAngleDist / (float)0.707 &&
                    graph.vertex[i].Item2.Y < p.Y + LAngleDist / (float)0.707 && graph.vertex[i].Item2.Y > p.Y - LAngleDist / (float)0.707) return false;

                graph.vertex.Add(new Tuple<string, PointF,Color>(num.ToString(), p, VertexColor));
                g.FillEllipse(new Pen(VertexColor).Brush, p.X - LAngleDist, p.Y - LAngleDist, 2 * LAngleDist / (float)1.414, 2 * LAngleDist / (float)1.414);
                g.DrawString(num.ToString(), new Font("Calibri", 10), new Pen(Color.Black).Brush, p.X - LAngleDist * (float)0.8, p.Y - LAngleDist * (float)0.8);
                num++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Повне перемальовування вершин з написами 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics reDrawAllVertex(Graphics g, float LAngleDist, Graph graph) {
            for (int i = 0; i < graph.vertex.Count;i++)
            {
                g.FillEllipse(new Pen(graph.vertex[i].Item3).Brush, graph.vertex[i].Item2.X - LAngleDist, graph.vertex[i].Item2.Y - LAngleDist, 2 * LAngleDist / (float)1.414, 2 * LAngleDist / (float)1.414);
                g.DrawString(graph.vertex[i].Item1.ToString(), new Font("Calibri", 10), new Pen(Color.Black).Brush, graph.vertex[i].Item2.X - LAngleDist * (float)0.8, graph.vertex[i].Item2.Y - LAngleDist * (float)0.8);
            }
            return g;
        }

        /// <summary>
        /// Видалення вершини з графу та її замальовування у колір фону 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="num"></param>
        /// <param name="graph"></param>
        /// <param name="BackGround"></param>
        /// <returns></returns>
        static public Graphics RemoveGraphVertexClick(Graphics g, PointF p, float LAngleDist, int num, ref Graph graph, Color BackGround)
        {
            for (int i = 0; i < graph.vertex.Count; i++) {
                if (graph.vertex[i].Item2.X < p.X + LAngleDist / (float)1.414 && graph.vertex[i].Item2.X > p.X - LAngleDist / (float)1.414 &&
                    graph.vertex[i].Item2.Y < p.Y + LAngleDist / (float)1.414 && graph.vertex[i].Item2.Y > p.Y - LAngleDist / (float)1.414)
                {
                    //Видалення всіх ребер, в яку входе вершина
                    for (int j = 0; j < graph.edge.Count; j++)
                    {
                        if (graph.edge[j].Item2 == graph.vertex[i].Item1 || graph.edge[j].Item1 == graph.vertex[i].Item1)
                        {
                            graph.edge.Remove(graph.edge[j]);
                            j--;
                        }
                    }

                    g.Clear(BackGround);
                    reDrawEdges(g, 15, graph);
                    graph.vertex.Remove(graph.vertex[i]);
                    reDrawAllVertex(g, 15, graph);
                    return g;
                }
            }
            return g;
        }

        /// <summary>
        /// Введення ребра у граф та його відмальовування 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="beginV"></param>
        /// <param name="endV"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics AddEdge(Graphics g, string beginV, string endV, float LAngleDist, ref Graph graph) {
            graph.edge.Add(new Tuple<string, string>(beginV, endV));

            PointF beginC, endC;
            bool check1, check2;
            check1 = check2 = false;
            beginC = endC = new PointF(0, 0);
            for (int i = 0; i < graph.vertex.Count; i++) {
                if (graph.vertex[i].Item1 == beginV) { beginC = graph.vertex[i].Item2; check1 = true; }
                if (graph.vertex[i].Item1 == endV) { endC = graph.vertex[i].Item2; check2 = true; }
                if (check1 && check2) break;
            }

            if (!(check1 && check2)) return g;
            
            //Здвиг точки кінця ребра до окружності з центру
            float r = (float)Math.Sqrt((endC.X - beginC.X) * (endC.X - beginC.X) + ((endC.Y - beginC.Y) * (endC.Y - beginC.Y)));
            endC = new PointF(endC.X + (beginC.X - endC.X)*LAngleDist / r, endC.Y + (beginC.Y - endC.Y) *LAngleDist / r);
            
            using (Pen p = new Pen(Color.Black))
            using (GraphicsPath capPath = new GraphicsPath())
            {
                capPath.AddPolygon(new Point[] { new Point(-5,0), new Point(0,5), new Point(5,0)});
                p.CustomEndCap = new CustomLineCap(null, capPath);
                g.DrawLine(p,  beginC.X-(float)4.5, beginC.Y- (float)4.5, endC.X-(float)4.5, endC.Y- (float)4.5);
            }

            reDrawAllVertex(g, LAngleDist, graph);
            return g;
        }

        /// <summary>
        /// Виделання ребра та подальше перемальвування всього графа
        /// </summary>
        /// <param name="g"></param>
        /// <param name="beginV"></param>
        /// <param name="endV"></param>
        /// <param name="graph"></param>
        /// <param name="backGround"></param>
        /// <returns></returns>
        static public Graphics removeEdge(Graphics g, string beginV, string endV, ref Graph graph, Color backGround)
        {
            graph.edge.Remove((new Tuple<string,string>(beginV,endV)));
            g.Clear(backGround);
            reDrawEdges(g, 15, graph);
            reDrawAllVertex(g, 15, graph);
            return g;
        }

        /// <summary>
        /// Перемальовування всіх ребер графу
        /// </summary>
        /// <param name="g"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics reDrawEdges(Graphics g, float LAngleDist, Graph graph) {
            for (int i = 0; i < graph.edge.Count;i++) {
                PointF beginC, endC;
                bool check1, check2;
                check1 = check2 = false;
                beginC = endC = new PointF(0, 0);
                for (int j = 0; j < graph.vertex.Count; j++)
                {
                    if (graph.vertex[j].Item1 == graph.edge[i].Item1) { beginC = graph.vertex[j].Item2; check1 = true; }
                    if (graph.vertex[j].Item1 == graph.edge[i].Item2) { endC = graph.vertex[j].Item2; check2 = true; }
                    if (check1 && check2) break;
                }
                if (!(check1 && check2)) return g;

                float r = (float)Math.Sqrt((endC.X - beginC.X) * (endC.X - beginC.X) + ((endC.Y - beginC.Y) * (endC.Y - beginC.Y)));
                endC = new PointF(endC.X + (beginC.X - endC.X) * LAngleDist / r, endC.Y + (beginC.Y - endC.Y) * LAngleDist / r);

                using (Pen p = new Pen(Color.Black))
                using (GraphicsPath capPath = new GraphicsPath())
                {
                    capPath.AddLine(-5, 0, 5, 0);
                    capPath.AddLine(-5, 0, 0, 5);
                    capPath.AddLine(0, 5, 5, 0);

                    p.CustomEndCap = new CustomLineCap(null, capPath);
                    g.DrawLine(p, beginC.X - (float)4.5, beginC.Y - (float)4.5, endC.X - (float)4.5, endC.Y - (float)4.5);
                }
            }
            return g;
        }

        /// <summary>
        /// Генерація довільного графа з вказаною кількістю ребер та вершин
        /// </summary>
        /// <param name="g"></param>
        /// <param name="graph"></param>
        /// <param name="vertex_num"></param>
        /// <param name="edge_num"></param>
        /// <param name="pictureBoxHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="BackGround"></param>
        /// <param name="VertexColor"></param>
        /// <returns></returns>
        static public Graphics randGeneration(ref Graphics g, ref Graph graph, int vertex_num, int edge_num, int pictureBoxHeight, int pictureBoxWidth, float LAngleDist, Color BackGround,Color VertexColor) {
            Random rand = new Random();
            graph = new Graph();
            g.Clear(BackGround);
            int num = 1; 
            string beginV, endV;
            for (int i = 0; i < vertex_num; i++)
                if(!EnterGraphVertex(ref g, new Point(rand.Next((int)LAngleDist,pictureBoxWidth- (int)LAngleDist ), rand.Next((int)LAngleDist,pictureBoxHeight- (int)LAngleDist)), LAngleDist, ref num,ref graph,vertex_num,VertexColor)) i--;
            for (int i = 0; i < edge_num; i++)
            {
                beginV = graph.vertex[rand.Next(graph.vertex.Count)].Item1;
                endV = graph.vertex[rand.Next(graph.vertex.Count)].Item1;
                if (beginV != endV && !graph.edge.Contains(new Tuple<string, string>(beginV, endV)))
                    graph.edge.Add(new Tuple<string, string>(beginV, endV));
                else i--;
            }
            reDrawEdges(g,LAngleDist, graph);
            reDrawAllVertex(g,LAngleDist,graph);
            
            return g;
        }

        /// <summary>
        /// Структура, яка зберігає строки MFI подання
        /// </summary>
        public struct MFI {
            public string G, P;
        }

        /// <summary>
        /// Генерація MFI подання графу
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static MFI MFIPresentation(Graph graph)
        {
            MFI mfi = new MFI();
            int counter = 0;
            bool change = false;
            foreach (Tuple<string,PointF, Color> vertex in graph.vertex) {
                foreach (Tuple<string, string> edge in graph.edge)
                    if (vertex.Item1 == edge.Item2) { counter++; mfi.G += edge.Item1+" "; change = true; }
                if (change)
                    mfi.P += counter+ " ";
                else mfi.P += "0 ";
                change = false;
            }
            return mfi;
        }

        /// <summary>
        /// Генерація списку суміжностей
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private static List<List<string>> makeAdjacency_list(Graph g) {
            List<List<string>> list = new List<List<string>>();
            for (int i = 0; i < g.vertex.Count; i++) {
                List<string> sublist = new List<string>();
                foreach (Tuple<string, string> edge in g.edge)
                {
                    if (edge.Item1 == g.vertex[i].Item1)
                        for (int j = 0; j < g.vertex.Count; j++)
                            if (g.vertex[j].Item1 == edge.Item2) sublist.Add(j.ToString());

                    if (edge.Item2 == g.vertex[i].Item1)
                        for (int j = 0; j < g.vertex.Count; j++)
                            if (g.vertex[j].Item1 == edge.Item1) sublist.Add(j.ToString());
                }
                list.Add(sublist);
            }
            return list;
        }

        static Random rand = new Random();
        /// <summary>
        /// Алгоритм розмальовування графу
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static Color[] greedyColoringAlg(Graph graph) {
            List<List<string>> adj = makeAdjacency_list(graph);
            int vCount = graph.vertex.Count;
            if (vCount == 0) return new Color[0];
            int[] result = new int[vCount];
            bool[] availible = new bool[vCount];
            result[0] = 0;
            availible[0]= false;
            for (int i = 1; i < vCount; i++)
            { 
                result[i] = -1;
                availible[i] = false;
            }

            for (int i = 0; i < vCount; i++) {
                foreach (string Vname in adj[i])
                    if (result[Int32.Parse(Vname)] != -1)
                        availible[result[Int32.Parse(Vname)]] = true;
                int j;
                for (j = 0; j < vCount; j++)
                    if (!availible[j])
                        break;
                result[i] = j; 

                foreach (string Vname in adj[i])
                    if (result[Int32.Parse(Vname)] != -1)
                        availible[result[Int32.Parse(Vname)]] = false;
            }
            Color[] colors = new Color[result.Max()+1];
            for (int i = 0; i < colors.Length; i++)
                colors[i] = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));

            for (int i = 0; i < vCount; i++)
                graph.vertex[i]= new Tuple<string, PointF, Color>(graph.vertex[i].Item1, graph.vertex[i].Item2, colors[result[i]]);
            return colors;
        }
    }
}
