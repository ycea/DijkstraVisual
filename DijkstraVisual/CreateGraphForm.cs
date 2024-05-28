using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraVisual
{
    public partial class CreateGraphForm : Form
    {
        public MatrixGraph theGraph;
        public Controller _controller;
        private Action<Controller> _controlDelegate;
        public CreateGraphForm()
        {
            theGraph = new MatrixGraph();
            _controller = new Controller(theGraph);
            InitializeComponent();
        }
        public void AddEvent(Action<Controller> action)
        {
            _controlDelegate = action;
        }
        private void DrawGraph(SearchState state)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            _controller = new Controller(theGraph);
            Graphics g = Graphics.FromImage(bmp);
            if (state == null)
            {
                _controller.drawGraph(g, pictureBox.Width, pictureBox.Height);
            }
            else
            {
                _controller.drawGraph(state, g);
            }
            pictureBox.Image = bmp;
        }
        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            if (FirstVertexComboBox.SelectedIndex == -1 || SecondVertexComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите 2 разные вершины");
                return;
            }
            else if (FirstVertexComboBox.SelectedIndex == SecondVertexComboBox.SelectedIndex)
            {
                MessageBox.Show("Вершины должны быть разными");
                return;
            }
            int start = FirstVertexComboBox.SelectedIndex;
            int end = SecondVertexComboBox.SelectedIndex;
            if (theGraph.adjMat[start, end] != int.MaxValue)
            {
                if (MessageBox.Show("Это ребро занято, переписать?", "Перезапись",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }
            theGraph.addEdge(FirstVertexComboBox.SelectedIndex, SecondVertexComboBox.SelectedIndex, (int)EdgeWeightValue.Value);
            DrawGraph(null);
        }
        private void resetEdges()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    theGraph.adjMat[i, j] = int.MaxValue;
                }
            }

        }
        private void ResetEdges_Click(object sender, EventArgs e)
        {
            resetEdges();
            _controller = new Controller(theGraph);

            DrawGraph(null);
        }
        private void AddVertexButton_Click(object sender, EventArgs e)
        {
            if (vertexLabel == null || vertexLabel.Text.Trim() == "")
            {
                MessageBox.Show("Введите название вершины");
                return;
            }
            if (theGraph.vertexList.Count == 5)
            {
                MessageBox.Show("Максимум 5 вершин");
                return;
            }

            theGraph.addVertex(vertexLabel.Text);
            FirstVertexComboBox.Items.Add(vertexLabel.Text);
            SecondVertexComboBox.Items.Add(vertexLabel.Text);
            selectVertextComboBox.Items.Add(vertexLabel.Text);
            DrawGraph(null);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(_controller != null)
            {
                _controlDelegate.Invoke(_controller);
            }
            Close();
        }

        private void RemoveVertexes_Click(object sender, EventArgs e)
        {
            resetEdges();
            FirstVertexComboBox.Items.Clear();
            SecondVertexComboBox.Items.Clear();
            selectVertextComboBox.Items.Clear();
            theGraph.vertexList.Clear();
            _controller = new Controller(theGraph);
            DrawGraph(null);

        }

        private void selectVertextComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectVertextComboBox.SelectedIndex != -1)
            {
                _controller.selectVertex(selectVertextComboBox.SelectedIndex);
            }
        }

        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            resetEdges();
            FirstVertexComboBox.Items.Clear();
            SecondVertexComboBox.Items.Clear();
            selectVertextComboBox.Items.Clear();
            theGraph.vertexList.Clear();
            FirstVertexComboBox.Items.Clear();
            SecondVertexComboBox.Items.Clear();
            selectVertextComboBox.Items.Clear();
            theGraph.generateRandomGraph();
            for(int i = 0; i < theGraph.vertexList.Count; i++)
            {
                FirstVertexComboBox.Items.Add(theGraph.vertexList[i].label);
                SecondVertexComboBox.Items.Add(theGraph.vertexList[i].label);
                selectVertextComboBox.Items.Add(theGraph.vertexList[i].label);
            }
            DrawGraph(null);
        }
    }
}
