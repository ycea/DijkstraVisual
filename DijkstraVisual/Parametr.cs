using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    public class Parametr
    {
        public int selectedVertex;
        public MatrixGraph graph;
        public Parametr(MatrixGraph _graph, int _selectedVertex)
        {
            this.graph = _graph;
            this.selectedVertex = _selectedVertex;
        }
    }
}
