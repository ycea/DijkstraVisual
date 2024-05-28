using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    /// <summary>
    /// класс реализатор
    /// </summary>
    public class DijkstraSearch
    {
        public DistPar[] sPath;
        public WorkState isWorking { get; private set; }
        private List<Vertex> vertexList;
        private int[,] adjMat; 
        private int nTree;
        private int nVerts;
        private int currentVert;
        private int startToCurrent; // Расстояние до currentVert
        private int _selectedVertex;
        public DijkstraSearch(Parametr parametr) 
        {
            _selectedVertex = parametr.selectedVertex;
            nTree = 0;
            nVerts = parametr.graph.vertexList.Count;
            vertexList = parametr.graph.vertexList;
            adjMat = parametr.graph.adjMat;
            sPath = new DistPar[vertexList.Count];
            currentVert = parametr.selectedVertex;
            for(int i = 0; i < vertexList.Count; i++)
            {
                sPath[i] = new DistPar(parametr.selectedVertex, adjMat[parametr.selectedVertex,i]);
                if (i == _selectedVertex)
                {
                    sPath[i] = new DistPar(parametr.selectedVertex, 0);
                }
            }

        }
        public SearchState saveState()
        {
            DistPar[] toSaveSPath = new DistPar[sPath.Length];
            Array.Copy(sPath, toSaveSPath, sPath.Length);
            SearchState resultState = new SearchState(toSaveSPath, nTree,currentVert);
            return resultState;
        }
        public void setState(SearchState state)
        {
            nTree = state.nTree;
            sPath = state.shortPath;
        }
        private void resetSDist()
        {
            nTree = 0; // Очистка дерева
            for (int j = 0; j < nVerts; j++)
                vertexList[j].isInTree = false;
        }
        public void Step() // Выбор кратчайших путей
        {

            if (nTree == nVerts)
            {
                isWorking = WorkState.Idle;
                resetSDist();
                return;
            }
            // Пока все вершины не окажутся в дереве
            if (nTree < nVerts)
            {
                isWorking = WorkState.Working;
                int indexMin = getMin(); // Получение минимума из sPath
                int minDist = sPath[indexMin].distance;
                if (minDist != int.MaxValue)
                {
                    currentVert = indexMin; // к ближайшей вершине
                    startToCurrent = sPath[indexMin].distance;
                    // Минимальное расстояние от startTree
                    // до currentVert равно startToCurrent
                }
                
                // Включение текущей вершины в дерево
                vertexList[currentVert].isInTree = true;
                nTree++;
                adjust_sPath(); // Обновление массива sPath[]
            }
        }
        private void adjust_sPath()
        {
            // Обновление данных в массиве кратчайших путей sPath
            int column = 0; // Начальная вершина пропускается
            while (column < nVerts) // Перебор столбцов
            {
                // Если вершина column уже включена в дерево, она пропускается
                if (vertexList[column].isInTree)
                {
                    column++;
                    continue;
                }
                // Вычисление расстояния для одного элемента sPath
                // Получение ребра от currentVert к column
                int currentToFringe = adjMat[currentVert, column];
                // Суммирование расстояний
                int startToFringe = startToCurrent + currentToFringe;
                if(startToFringe < 0)
                {
                    startToFringe = int.MaxValue;
                }
                // Определение расстояния текущего элемента sPath
                int sPathDist = sPath[column].distance;
                // Сравнение расстояния от начальной вершины с элементом sPath
                if (startToFringe < sPathDist) // Если меньше,
                { // данные sPath обновляются
                    sPath[column] = new DistPar(currentVert,startToFringe);
                }
                column++;
            }
        }
        private int getMin() // Поиск в sPath элемента
        { // с наименьшим расстоянием
            int minDist = int.MaxValue; // Исходный высокий "минимум"
            int indexMin = _selectedVertex;
            for (int j = 0; j < nVerts; j++) // Для каждой вершины
            { // Если она не включена в дерево
                if (!vertexList[j].isInTree && // и ее расстояние меньше
                sPath[j].distance < minDist && sPath[j].distance != 0) // старого минимума
                {
                    minDist = sPath[j].distance;
                    indexMin = j; // Обновление минимума
                }
            }
            return indexMin; // Метод возвращает индекс
        }
        // -------------------------------------------------------------
    }
}
