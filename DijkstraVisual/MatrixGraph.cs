namespace DijkstraVisual
{
    public class MatrixGraph
    {
        private readonly int MAX_VERTS = 5;
        private string alph = "ABCDE";
        public List<Vertex> vertexList;
        public int[,] adjMat;
        public MatrixGraph()
        {

            vertexList = new List<Vertex> { };
            adjMat = new int[MAX_VERTS, MAX_VERTS];
            for (int i = 0; i < MAX_VERTS; i++)
            {
                for (int j = 0; j < MAX_VERTS; j++)
                {
                    adjMat[i, j] = int.MaxValue;
                }
            }

        }
        public void addVertex(string lab)
        {
            vertexList.Add(new Vertex(lab));

        }
        public void addEdge(int start, int end, int weight)
        {
            adjMat[start, end] = weight;
            adjMat[end, start] = weight;

        }
        public void generateRandomGraph()
        {
            Random rand = new Random();
            int vertexes = rand.Next(MAX_VERTS) + 1;
            int edges = rand.Next(vertexes) * 2;
            for (int i = 0; i < vertexes; i++)
            {
                addVertex(alph[i].ToString());
            }
            for (int i = 0; i < edges; i++)
            {
                int randVert = rand.Next(vertexes);
                addEdge(randVert, (randVert + 1) % vertexes, rand.Next(100));
            }
        }
    }

}