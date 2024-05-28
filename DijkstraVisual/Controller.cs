using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DijkstraVisual
{
    /// <summary>
    /// класс управленец
    /// </summary>
    public class Controller
    {
        VisualSearch visualSearch;
        MatrixGraph graph;
        public DijkstraSearch search { get; private set; }
        public StateStorage stateStorage { get; private set; }
        public bool counted {  get; private set; }
        private int startVertex = 0;
        public Controller(MatrixGraph _graph)
        {
            graph = _graph;
            counted = false;
            stateStorage = new StateStorage(graph);
            search = new DijkstraSearch(new Parametr(graph, startVertex));
            startVertex = 0;
            visualSearch = new VisualSearch(graph, search.sPath);

        }
        public void countPaths()
        {
            while (search.isWorking == WorkState.Working)
            {
                stateStorage.addState(search.saveState());
                search.Step();

            }
            counted = true;
        }
        public void drawGraph(Graphics g, int picWidth, int picHeight)
        {
            visualSearch.SetPictureSize(picWidth, picHeight);
            visualSearch.SetPosition(picWidth/2, picHeight/4);
            visualSearch.drawGraph(g,null);
        }
        public void drawGraph(SearchState currentState,Graphics g) 
        {
            visualSearch.drawGraph(g, currentState);
        }
        public string getState (SearchState state)
        {
            return visualSearch.getState(state);
        }
        private void resetSearch()
        {
            search = new DijkstraSearch(new Parametr(graph,startVertex));
            counted = false;
            stateStorage.resetStorage();
        }
        public void setNewGraph(MatrixGraph grph) 
        {
            graph = grph;
            resetSearch();
        }
        public SearchState NextState()
        {
            return stateStorage.nextState();
        }
        public SearchState PrevState()
        {
            return stateStorage.previousState();
        }
        public SearchState ReturnToState(int index)
        {
            stateStorage.setState(index);
            return stateStorage.currentState();
        }
 
        public void selectVertex(int start)
        {
            startVertex = start;
            search = new DijkstraSearch(new Parametr(graph, startVertex));
            visualSearch = new VisualSearch(graph, search.sPath);
        }
        public void goToStart()
        {
            stateStorage.goToStart();

        }
        public void SaveData(string filename)
        {
            stateStorage.saveStorage(filename);
        }
        public void LoadData(string filename)
        {
            stateStorage.loadData(filename);
            startVertex = stateStorage.selectedVertex;
            graph = stateStorage.graph;
            search = new DijkstraSearch(new Parametr(graph,startVertex));
            visualSearch = new VisualSearch(graph, search.sPath);
            counted = true;
        }
    }
}
