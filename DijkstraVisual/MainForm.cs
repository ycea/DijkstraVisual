
using System.Windows.Forms;

namespace DijkstraVisual
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        MatrixGraph theGraph = new MatrixGraph();
        Controller controller;
        int currentState = -1;
        int lookedStates = -1;
        public MainForm()
        {
            InitializeComponent();

            controller = new Controller(theGraph);
        }


        private void drawStates(SearchState state)
        {
            stateBox.Items.Clear();
            if (lookedStates == -1)
            {
                for (int i = 0; i <= currentState; i++)
                {
                    stateBox.Items.Add(controller.getState(controller.stateStorage.searchStates[i]));
                }
            }
            else
            {
                for (int i = 0; i <= lookedStates; i++)
                {
                    stateBox.Items.Add(controller.getState(controller.stateStorage.searchStates[i]));
                }
            }
        }
        private void DrawGraph(SearchState state)
        {

            if (controller == null) { return; }
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            if (state == null)
            {
                controller.drawGraph(g, pictureBox.Width, pictureBox.Height);
            }
            else
            {
                controller.drawGraph(state, g);
                drawStates(state);
            }
            pictureBox.Image = bmp;
        }
        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (currentState >= controller.stateStorage.searchStates.Count-1)
            {
                lookedStates = currentState;
                return;
            }
            if (controller.counted == false)
            {
                controller.countPaths();
            }
            SearchState state = controller.NextState();
            currentState += 1;
            if (state != null)
            {
                DrawGraph(state);

            }
  
        }

        private void buttonPreviousStep_Click(object sender, EventArgs e)
        {
            if (currentState < 0)
            {
                return;
            }

            SearchState state = controller.PrevState();
            currentState -= 1;
            if (state != null)
            {
                DrawGraph(state);
            }
  

        }

        private void goToStart(object sender, EventArgs e)
        {
            controller.goToStart();
            currentState = 1;
            DrawGraph(controller.NextState());
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                controller.SaveData(saveFileDialog.FileName);
                MessageBox.Show("Ñîõðàíåíèå ïðîøëî óñïåøíî", "Ðåçóëüòàò", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                controller.LoadData(openFileDialog.FileName);
                DrawGraph(null);
            }
        }
        private void saveController(Controller _contoller)
        {
            controller = _contoller;
            DrawGraph(null);
            controller.countPaths();
            lookedStates = -1;
            currentState = -1;
            stateBox.Items.Clear();
        }
        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            CreateGraphForm createGraphForm = new CreateGraphForm();
            createGraphForm.AddEvent(saveController);
            createGraphForm.Show();
        }
        private void èíôîðìàöèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformForm form = new InformForm();
            form.ShowDialog();
        }

        private void stateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentState = (int)stateBox.SelectedIndex;
            DrawGraph(controller.ReturnToState(currentState));
        }
    }
}
