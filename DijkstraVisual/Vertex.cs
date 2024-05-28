using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraVisual
{
    public class Vertex
    {
        public bool isInTree;
        public string label;
        public Vertex(string lab)
        {
            label = lab;
            isInTree = false;
        }
    }
}
