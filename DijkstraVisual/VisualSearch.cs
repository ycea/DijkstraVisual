using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    /// <summary>
    /// класс визуализатор
    /// </summary>
    public class VisualSearch
    {
        private int cellWidth;
        private int cellHeight;
        private int? _pictureWidth;
        private int? _pictureHeight;
        private int edgeLength;
        private int? _startPosX;
        private int? _startPosY;
        private (int x, int y)[] cells;
        Point[] points = new Point[5]; // Задаем вершины многоугольника (в этом примере - шестиугольника)
        public MatrixGraph graph {private get; set; }
        public DistPar[] sPaths { private get; set; }
        public VisualSearch(MatrixGraph _graph, DistPar[] _sPaths)
        {
            edgeLength = 70;
            cellHeight = 20;
            cellWidth = 20;
            cells = new (int x, int y)[5];
            graph = _graph;
            sPaths = _sPaths;
            for(int i = 0; i < _graph.vertexList.Count; i++)
            {
                int x = edgeLength + 20 + (int)(-edgeLength * Math.Cos(2 * Math.PI / 6 * -i)); // Вычисляем x координату точки
                int y = edgeLength + 20 + (int)(-edgeLength * Math.Sin(2 * Math.PI / 6 * -i)); // Вычисляем y координату точки
                points[i] = new Point(x, y); // Задаем точки
            }
        }
        public bool SetPictureSize(int width, int height)
        {

            if (width <= cellWidth || height <=cellHeight)
            {
                return false;
            };
            _pictureWidth = width;
            _pictureHeight = height;
            if (_startPosX.HasValue && _startPosY.HasValue)
            {
                if (_startPosX + cellWidth > _pictureWidth)
                {
                    _startPosX = _pictureWidth.Value - cellWidth;
                }
                if (_startPosY + cellHeight > _pictureHeight)
                {
                    _startPosY = _pictureHeight.Value - cellHeight;
                }
            }

            return true;
        }

        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>

        public void SetPosition(int x, int y)
        {
            if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }

            if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }

            _startPosX = x+edgeLength;
            _startPosY = y;

            if (cellHeight + y > _pictureHeight || y < 0)
            {
                _startPosY = 0;
            }
            if (cellWidth + x > _pictureWidth || x < 0)
            {
                _startPosX = 0;
            }

            return;

        }
        public string getState(SearchState state)
        {
            if(state == null)
            {
                return "NULL";
            }
            Brush brushText = new SolidBrush(Color.Black);
            Font stateFont = new Font("Calibri", 10);
            string stateString = "";
            for(int i = 0; i < graph.vertexList.Count;i++)
            {
                stateString += graph.vertexList[i].label + "=";
                if (state.shortPath[i].distance == int.MaxValue)
                {
                    stateString += "inf";
                }
                else
                {
                    stateString += state.shortPath[i].distance.ToString();

                }
                string parent = graph.vertexList[state.shortPath[i].parentVert].label;
                stateString += "(" + parent + ") ";
            }
            return stateString;
        }
        public void drawGraph(Graphics g,SearchState state)
        {
            Pen pen = new Pen(Color.Gray);
            pen.Width = 3;
            Brush brushPoint = new SolidBrush(Color.Gray);
            Font labelFont = new Font("Calibri", 10);
            Brush brushText = new SolidBrush(Color.Red);
            Font weightFont = new Font("Calibri", 10);
            Brush selectedText = new SolidBrush(Color.Blue);

            for (int i = 0; i < graph.vertexList.Count; i++)
            {
                g.FillEllipse(brushPoint, points[i].X, points[i].Y, cellWidth, cellHeight); // Рисуем круглую точку в заданных координатах
            }
            for(int i = 0; i < graph.vertexList.Count-1;i++)
            {
                for (int j = 0; j < graph.vertexList.Count; j++)
                {
                    if (graph.adjMat[i,j] < int.MaxValue && graph.adjMat[i, j] != 0)
                    {

                        g.DrawLine(pen, points[i].X+cellWidth/2, points[i].Y + cellHeight / 2, points[j].X + cellWidth / 2, points[j].Y + cellHeight / 2);
                        float middleX = ((points[i].X + cellWidth / 2) + (points[j].X + cellWidth / 2)) / 2 - 10;
                        float middleY = ((points[i].Y + cellWidth / 2) + (points[j].Y + cellWidth / 2)) / 2;
                        g.DrawString(graph.adjMat[i, j].ToString(), weightFont, brushText, middleX, middleY);

                    }
                }
            }
            for(int i = 0; i < graph.vertexList.Count; i++)
            {
                if (state?.selectedVertex == i && state != null)
                {
                    g.DrawString(graph.vertexList[i].label, labelFont, selectedText, points[i]);
                    continue;
                }
                g.DrawString(graph.vertexList[i].label, labelFont, brushText, points[i]);
            }
        }

    }
}

