namespace DijkstraVisual
{
    partial class CreateGraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            FirstVertexComboBox = new ComboBox();
            label1 = new Label();
            SecondVertexComboBox = new ComboBox();
            label3 = new Label();
            EdgeWeightValue = new NumericUpDown();
            AddEdgeButton = new Button();
            ResetEdges = new Button();
            label5 = new Label();
            selectVertextComboBox = new ComboBox();
            pictureBox = new PictureBox();
            panel1 = new Panel();
            vertexLabel = new MaskedTextBox();
            RemoveVertexes = new Button();
            AddVertexButton = new Button();
            label4 = new Label();
            SaveButton = new Button();
            buttonCreateGraph = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EdgeWeightValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(FirstVertexComboBox);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(SecondVertexComboBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(EdgeWeightValue);
            flowLayoutPanel1.Controls.Add(AddEdgeButton);
            flowLayoutPanel1.Controls.Add(ResetEdges);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(selectVertextComboBox);
            flowLayoutPanel1.Location = new Point(632, 190);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(166, 289);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Первая вершина";
            // 
            // FirstVertexComboBox
            // 
            FirstVertexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FirstVertexComboBox.FormattingEnabled = true;
            FirstVertexComboBox.Location = new Point(3, 23);
            FirstVertexComboBox.Name = "FirstVertexComboBox";
            FirstVertexComboBox.Size = new Size(151, 28);
            FirstVertexComboBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 54);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Вторая вершина";
            // 
            // SecondVertexComboBox
            // 
            SecondVertexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SecondVertexComboBox.FormattingEnabled = true;
            SecondVertexComboBox.Location = new Point(3, 77);
            SecondVertexComboBox.Name = "SecondVertexComboBox";
            SecondVertexComboBox.Size = new Size(151, 28);
            SecondVertexComboBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Вес ребра";
            // 
            // EdgeWeightValue
            // 
            EdgeWeightValue.Location = new Point(3, 131);
            EdgeWeightValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EdgeWeightValue.Name = "EdgeWeightValue";
            EdgeWeightValue.Size = new Size(154, 27);
            EdgeWeightValue.TabIndex = 7;
            EdgeWeightValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddEdgeButton
            // 
            AddEdgeButton.Location = new Point(3, 164);
            AddEdgeButton.Name = "AddEdgeButton";
            AddEdgeButton.Size = new Size(154, 29);
            AddEdgeButton.TabIndex = 4;
            AddEdgeButton.Text = "Добавить ребро";
            AddEdgeButton.UseVisualStyleBackColor = true;
            AddEdgeButton.Click += AddEdgeButton_Click;
            // 
            // ResetEdges
            // 
            ResetEdges.Location = new Point(3, 199);
            ResetEdges.Name = "ResetEdges";
            ResetEdges.Size = new Size(154, 29);
            ResetEdges.TabIndex = 2;
            ResetEdges.Text = "Очистить ребра";
            ResetEdges.UseVisualStyleBackColor = true;
            ResetEdges.Click += ResetEdges_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 231);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 8;
            label5.Text = "Вершина для старта";
            // 
            // selectVertextComboBox
            // 
            selectVertextComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectVertextComboBox.FormattingEnabled = true;
            selectVertextComboBox.Location = new Point(3, 254);
            selectVertextComboBox.Name = "selectVertextComboBox";
            selectVertextComboBox.Size = new Size(151, 28);
            selectVertextComboBox.TabIndex = 8;
            selectVertextComboBox.SelectedIndexChanged += selectVertextComboBox_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(28, 79);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(420, 241);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(vertexLabel);
            panel1.Controls.Add(RemoveVertexes);
            panel1.Controls.Add(AddVertexButton);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(632, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 172);
            panel1.TabIndex = 6;
            // 
            // vertexLabel
            // 
            vertexLabel.Location = new Point(9, 35);
            vertexLabel.Mask = "?";
            vertexLabel.Name = "vertexLabel";
            vertexLabel.Size = new Size(148, 27);
            vertexLabel.TabIndex = 4;
            // 
            // RemoveVertexes
            // 
            RemoveVertexes.Location = new Point(6, 124);
            RemoveVertexes.Name = "RemoveVertexes";
            RemoveVertexes.Size = new Size(151, 29);
            RemoveVertexes.TabIndex = 3;
            RemoveVertexes.Text = "Очистить вершины";
            RemoveVertexes.UseVisualStyleBackColor = true;
            RemoveVertexes.Click += RemoveVertexes_Click;
            // 
            // AddVertexButton
            // 
            AddVertexButton.Location = new Point(6, 80);
            AddVertexButton.Name = "AddVertexButton";
            AddVertexButton.Size = new Size(151, 29);
            AddVertexButton.TabIndex = 2;
            AddVertexButton.Text = "Добавить вершину";
            AddVertexButton.UseVisualStyleBackColor = true;
            AddVertexButton.Click += AddVertexButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 0;
            label4.Text = "Имя вершины";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(28, 420);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // buttonCreateGraph
            // 
            buttonCreateGraph.Location = new Point(167, 420);
            buttonCreateGraph.Name = "buttonCreateGraph";
            buttonCreateGraph.Size = new Size(189, 29);
            buttonCreateGraph.TabIndex = 8;
            buttonCreateGraph.Text = "Сгенерировать граф";
            buttonCreateGraph.UseVisualStyleBackColor = true;
            buttonCreateGraph.Click += buttonCreateGraph_Click;
            // 
            // CreateGraphForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(buttonCreateGraph);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            Controls.Add(pictureBox);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateGraphForm";
            Text = "Создание графов";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EdgeWeightValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox FirstVertexComboBox;
        private Label label1;
        private ComboBox SecondVertexComboBox;
        private Label label3;
        private NumericUpDown EdgeWeightValue;
        private Button AddEdgeButton;
        private Button ResetEdges;
        private PictureBox pictureBox;
        private Panel panel1;
        private Button AddVertexButton;
        private Label label4;
        private Button RemoveVertexes;
        private Button SaveButton;
        private MaskedTextBox vertexLabel;
        private Label label5;
        private ComboBox selectVertextComboBox;
        private Button buttonCreateGraph;
    }
}