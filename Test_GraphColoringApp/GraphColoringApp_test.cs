using System;
using Xunit;
using Course_Work_paintingGraph;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Test_GraphColoringApp
{
    public class GraphColoringApp_test
    {
        [Fact]
        public void OneVertexAdd_Test()
        {
            Graph graph = new Graph();
            graph.vertex.Add(new Tuple<string, PointF, Color>("A",new Point(0,0),Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("B", new Point(3, 1), Color.Blue));
            graph.vertex.Add(new Tuple<string, PointF, Color>("C", new Point(-1, 55), Color.Red));

            Assert.Equal(Color.White,graph.vertex[0].Item3);
            Assert.Equal(1, graph.vertex[1].Item2.Y);
            Assert.Equal("C", graph.vertex[2].Item1);
        }

        [Fact]
        public void ListVertexEdgeAdd_Test()
        {
            var testV = new List<Tuple<string, PointF, Color>>();
            testV.Add(new Tuple<string, PointF, Color>("A", new Point(0, 0), Color.White));
            testV.Add(new Tuple<string, PointF, Color>("B", new Point(3, 1), Color.Blue));
            testV.Add(new Tuple<string, PointF, Color>("C", new Point(-1, 55), Color.Red));

            var testE = new List<Tuple<string, string>>();
            testE.Add(new Tuple<string,string>("B","C"));

            Graph graph = new Graph(testV, testE);

            Assert.Equal(Color.White, graph.vertex[0].Item3);
            Assert.Equal(1, graph.vertex[1].Item2.Y);
            Assert.Equal("C", graph.vertex[2].Item1);
            Assert.Equal("C",graph.edge[0].Item2);
        }

        [Fact]
        public void ColoringAlgorithm() {
            Graph graph = new Graph();
            //Для тесту візьмемо граф з рис. 1.1 - Граф Петерсена
            //При створенні вершин, координатами можемо знехтувати
            graph.vertex.Add(new Tuple<string, PointF, Color>("1", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("2", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("3", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("4", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("5", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("6", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("7", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("8", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("9", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("10", new Point(0, 0), Color.White));

            graph.edge.Add(new Tuple<string, string>("1","2"));
            graph.edge.Add(new Tuple<string, string>("2", "3"));
            graph.edge.Add(new Tuple<string, string>("3", "4"));
            graph.edge.Add(new Tuple<string, string>("4", "5"));
            graph.edge.Add(new Tuple<string, string>("5", "1"));
            graph.edge.Add(new Tuple<string, string>("6", "2"));
            graph.edge.Add(new Tuple<string, string>("7", "3"));
            graph.edge.Add(new Tuple<string, string>("7", "8"));
            graph.edge.Add(new Tuple<string, string>("7", "10"));
            graph.edge.Add(new Tuple<string, string>("8", "1"));
            graph.edge.Add(new Tuple<string, string>("8", "9"));
            graph.edge.Add(new Tuple<string, string>("9", "4"));
            graph.edge.Add(new Tuple<string, string>("9", "6"));
            graph.edge.Add(new Tuple<string, string>("10", "5"));
            graph.edge.Add(new Tuple<string, string>("10", "6"));

            Color[] colors = Logic.greedyColoringAlg(graph);

            //Тест на коректність вираховування хроматичного числа, беремо максимальне значення 4, бо Жадібний
            //алгоритм обіцяє вирахувати максимальне хроматичне число не більше ніж максимальна ступінь вершини плюс 1
            Assert.True(4>=colors.Length);

            //Тест на правильність розфарбовування графа, для цього, наприклад, візьмемо останне введене ребро та порівняємо кольори його кінців
            Assert.True(graph.vertex[9].Item3 != graph.vertex[5].Item3);
        }

        [Fact]
        public void MFIGen_Test()
        {
            Graph graph = new Graph();
            //Для тесту візьмемо граф з рис. 1.1 - Граф Петерсена
            //При створенні вершин, координатами можемо знехтувати
            graph.vertex.Add(new Tuple<string, PointF, Color>("1", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("2", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("3", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("4", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("5", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("6", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("7", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("8", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("9", new Point(0, 0), Color.White));
            graph.vertex.Add(new Tuple<string, PointF, Color>("10", new Point(0, 0), Color.White));

            graph.edge.Add(new Tuple<string, string>("1", "2"));
            graph.edge.Add(new Tuple<string, string>("2", "3"));
            graph.edge.Add(new Tuple<string, string>("3", "4"));
            graph.edge.Add(new Tuple<string, string>("4", "5"));
            graph.edge.Add(new Tuple<string, string>("5", "1"));
            graph.edge.Add(new Tuple<string, string>("6", "2"));
            graph.edge.Add(new Tuple<string, string>("7", "3"));
            graph.edge.Add(new Tuple<string, string>("7", "8"));
            graph.edge.Add(new Tuple<string, string>("7", "10"));
            graph.edge.Add(new Tuple<string, string>("8", "1"));
            graph.edge.Add(new Tuple<string, string>("8", "9"));
            graph.edge.Add(new Tuple<string, string>("9", "4"));
            graph.edge.Add(new Tuple<string, string>("9", "6"));
            graph.edge.Add(new Tuple<string, string>("10", "5"));
            graph.edge.Add(new Tuple<string, string>("10", "6"));

            Logic.MFI m = Logic.MFIPresentation(graph);

            Assert.Equal("5 8 1 6 2 7 3 9 4 10 9 10 7 8 7 ",m.G);
            Assert.Equal("2 4 6 8 10 12 0 13 14 15 ", m.P);
        }
    }
}
