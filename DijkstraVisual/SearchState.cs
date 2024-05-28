using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    /// <summary>
    /// класс состояние
    /// </summary>
    public class SearchState
    {
        public DistPar[] shortPath;
        public int nTree;
        public int selectedVertex;
        public SearchState (DistPar[] _shortPath, int _nTree, int _selectedVertex)
        {
            shortPath = new DistPar[_shortPath.Length];
            Array.Copy(_shortPath, shortPath, _shortPath.Length);
            nTree = _nTree;
            selectedVertex= _selectedVertex;
        }
    }
}
