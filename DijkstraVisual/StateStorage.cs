using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    /// <summary>
    /// класс хранилище состояний
    /// </summary>
    public class StateStorage
    {
        public List<SearchState> searchStates { get; private set; }
        private int currentStateInd;
        public int selectedVertex;
        public MatrixGraph graph;
        public StateStorage(MatrixGraph g) 
        {
            graph = g;
            currentStateInd = -1;
            searchStates = new List<SearchState>();
        }
        public void addState (SearchState _state)
        {
            searchStates.Add(_state);
        }
        public SearchState nextState() 
        { 
            if(currentStateInd < searchStates.Count-1 ) 
            {
                
                return searchStates[currentStateInd++ + 1];
            }
            return null;
        }

        public SearchState previousState() 
        {
            if(currentStateInd >= 0) 
            {
                
                return searchStates[currentStateInd--];
            }
            return null;
        }
        public void setState(int index)
        {
            if(index < searchStates.Count  && index >= 0)
            {
                currentStateInd = index;
            }
        }
        public SearchState currentState()
        {
            if(currentStateInd < searchStates.Count-1 && currentStateInd >= 0)
            {
                return searchStates[currentStateInd];
            }
            return null;
        }
        public void goToStart()
        {
            currentStateInd = -1;
        }
        public void resetStorage()
        {
            searchStates.Clear();
            currentStateInd = -1;
        }
        public void saveStorage(string filename)
        {
            if(searchStates.Count == 0) 
            {
                return;
            }
            if(File.Exists(filename))
            {
                File.Delete(filename);
            }
            using FileStream fs = new(filename, FileMode.Create);
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < graph.vertexList.Count; i++)
            {
                stringBuilder.Append(graph.vertexList[i].label+" ");
            }
            stringBuilder.Append('\n');
            stringBuilder.Append(selectedVertex.ToString());
            stringBuilder.Append("\n");
            for(int i = 0; i < graph.vertexList.Count; i++)
            {
                for(int j = 0; j < graph.vertexList.Count; j++)
                {
                    stringBuilder.Append(graph.adjMat[i,j].ToString()+" ");
                }
                stringBuilder.Append("\n");
            }
            for(int i = 0; i < searchStates.Count; i++)
            {
                stringBuilder.Append(searchStates[i].nTree.ToString() + " " + searchStates[i].selectedVertex.ToString());
                stringBuilder.Append("\n");
                for(int j = 0; j < searchStates[i].shortPath.Length; j++) 
                {
                    stringBuilder.Append(searchStates[i].shortPath[j].distance.ToString() + " " + searchStates[i].shortPath[j].parentVert.ToString() + " ");
                }
                stringBuilder.Append("\n");
            }
            byte[] info = new UTF8Encoding(true).GetBytes(stringBuilder.ToString());
            fs.Write(info, 0, info.Length);
        }
        public void loadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }
            searchStates.Clear();
            using (FileStream fs = new(filename, FileMode.Open))
            {
                StreamReader streamReader = new StreamReader(fs);
                List<string> vertexLabels = streamReader.ReadLine().Split().ToList();
                List<Vertex> vertexList = new List<Vertex>();
                vertexLabels.Remove("");
                for (int i = 0; i < vertexLabels.Count; i++)
                {
                    vertexList.Add( new Vertex(vertexLabels[i]));
                }
                
                selectedVertex = int.Parse(streamReader.ReadLine());
                graph.vertexList = vertexList;
                int[,] adjMat = new int[vertexLabels.Count, vertexLabels.Count];
                for(int i = 0; i < vertexLabels.Count; i++)
                {
                    string[] lineAdjLine = streamReader.ReadLine().Split().ToArray();
                    for(int j = 0;j < lineAdjLine.Length-1; j++)
                    {
                        adjMat[i, j] = int.Parse(lineAdjLine[j]);
                    }
                }

                graph.adjMat = adjMat;
                for(int i = 0;i < vertexLabels.Count+1; i++)
                {
                    string[] stateString = streamReader.ReadLine().Split();
                    int current = int.Parse(stateString[1]);
                    int nVerts = int.Parse(stateString[0]);
                    DistPar[] distPars = new DistPar[vertexLabels.Count];
                    string[] lineShortPath = streamReader.ReadLine().Split();
                    for(int j = 0; j < vertexLabels.Count; j++)
                    {
                        DistPar distPar = new DistPar(int.Parse(lineShortPath[2*j+1]), int.Parse(lineShortPath[2*j]));
                        distPars[j] = distPar;
                    }
                    SearchState searchState = new SearchState(distPars, nVerts,current);
                    searchStates.Add(searchState);
                }
            }
        }
    }
}
