namespace DijkstraVisual
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonNextStep = new Button();
            label4 = new Label();
            buttonPreviousStep = new Button();
            pictureBox = new PictureBox();
            buttonCreateGraph = new Button();
            buttonToStart = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранениеToolStripMenuItem = new ToolStripMenuItem();
            загрузкаToolStripMenuItem = new ToolStripMenuItem();
            информацияToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            stateBox = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNextStep
            // 
            buttonNextStep.Location = new Point(675, 385);
            buttonNextStep.Name = "buttonNextStep";
            buttonNextStep.Size = new Size(142, 29);
            buttonNextStep.TabIndex = 0;
            buttonNextStep.Text = "Следующий шаг";
            buttonNextStep.UseVisualStyleBackColor = true;
            buttonNextStep.Click += buttonNextStep_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 43);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Граф";
            // 
            // buttonPreviousStep
            // 
            buttonPreviousStep.Location = new Point(675, 430);
            buttonPreviousStep.Name = "buttonPreviousStep";
            buttonPreviousStep.Size = new Size(139, 29);
            buttonPreviousStep.TabIndex = 7;
            buttonPreviousStep.Text = "Предыдущий шаг";
            buttonPreviousStep.UseVisualStyleBackColor = true;
            buttonPreviousStep.Click += buttonPreviousStep_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(33, 78);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(436, 358);
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            // 
            // buttonCreateGraph
            // 
            buttonCreateGraph.Location = new Point(675, 289);
            buttonCreateGraph.Name = "buttonCreateGraph";
            buttonCreateGraph.Size = new Size(142, 29);
            buttonCreateGraph.TabIndex = 9;
            buttonCreateGraph.Text = "Создать граф";
            buttonCreateGraph.UseVisualStyleBackColor = true;
            buttonCreateGraph.Click += buttonCreateGraph_Click;
            // 
            // buttonToStart
            // 
            buttonToStart.Location = new Point(675, 350);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(142, 29);
            buttonToStart.TabIndex = 10;
            buttonToStart.Text = "В начало";
            buttonToStart.UseVisualStyleBackColor = true;
            buttonToStart.Click += goToStart;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "bin file | *.bin";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, информацияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранениеToolStripMenuItem, загрузкаToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранениеToolStripMenuItem
            // 
            сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            сохранениеToolStripMenuItem.Size = new Size(177, 26);
            сохранениеToolStripMenuItem.Text = "Сохранение";
            сохранениеToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // загрузкаToolStripMenuItem
            // 
            загрузкаToolStripMenuItem.Name = "загрузкаToolStripMenuItem";
            загрузкаToolStripMenuItem.Size = new Size(177, 26);
            загрузкаToolStripMenuItem.Text = "Загрузка";
            загрузкаToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Size = new Size(116, 24);
            информацияToolStripMenuItem.Text = "Информация";
            информацияToolStripMenuItem.Click += информацияToolStripMenuItem_Click;
            // 
            // stateBox
            // 
            stateBox.FormattingEnabled = true;
            stateBox.HorizontalScrollbar = true;
            stateBox.ItemHeight = 20;
            stateBox.Location = new Point(475, 78);
            stateBox.Name = "stateBox";
            stateBox.Size = new Size(342, 184);
            stateBox.TabIndex = 12;
            stateBox.SelectedIndexChanged += stateBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 47);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 13;
            label1.Text = "Список состояний";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 489);
            Controls.Add(label1);
            Controls.Add(stateBox);
            Controls.Add(buttonToStart);
            Controls.Add(buttonCreateGraph);
            Controls.Add(pictureBox);
            Controls.Add(buttonPreviousStep);
            Controls.Add(label4);
            Controls.Add(buttonNextStep);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Алгоритм Дейкстры";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNextStep;
        private Label label4;
        private Button buttonPreviousStep;
        private PictureBox pictureBox;
        private Button buttonCreateGraph;
        private Button buttonToStart;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранениеToolStripMenuItem;
        private ToolStripMenuItem загрузкаToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem информацияToolStripMenuItem;
        private ListBox stateBox;
        private Label label1;
    }
}
