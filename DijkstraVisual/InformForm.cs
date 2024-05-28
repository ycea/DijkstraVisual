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
    public partial class InformForm : Form
    {
        public InformForm()
        {
            InitializeComponent();
        }

        private void InformForm_Load(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "inform.txt";
            string filePath = Path.Combine(currentDirectory, fileName);
            using (FileStream fs = new(filePath, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    richTextBox.Text += sr.ReadLine();
                    richTextBox.Text += "\n";
                }
            }
        }
    }
}
