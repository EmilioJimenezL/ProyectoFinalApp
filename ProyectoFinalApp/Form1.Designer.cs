namespace ProyectoFinalApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolsPanel = new Panel();
            showMapButton = new Button();
            instructionLBox = new ListBox();
            statusLabel = new Label();
            buscarButton = new Button();
            haciaLabel = new Label();
            desdeLabel = new Label();
            haciaComboBox = new ComboBox();
            desdeComboBox = new ComboBox();
            viewerPanel = new Panel();
            gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            toolsPanel.SuspendLayout();
            viewerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(showMapButton);
            toolsPanel.Controls.Add(instructionLBox);
            toolsPanel.Controls.Add(statusLabel);
            toolsPanel.Controls.Add(buscarButton);
            toolsPanel.Controls.Add(haciaLabel);
            toolsPanel.Controls.Add(desdeLabel);
            toolsPanel.Controls.Add(haciaComboBox);
            toolsPanel.Controls.Add(desdeComboBox);
            toolsPanel.Dock = DockStyle.Right;
            toolsPanel.Location = new Point(708, 0);
            toolsPanel.MinimumSize = new Size(250, 470);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Padding = new Padding(5);
            toolsPanel.Size = new Size(250, 636);
            toolsPanel.TabIndex = 0;
            // 
            // showMapButton
            // 
            showMapButton.Location = new Point(12, 540);
            showMapButton.Margin = new Padding(5);
            showMapButton.Name = "showMapButton";
            showMapButton.Size = new Size(224, 23);
            showMapButton.TabIndex = 7;
            showMapButton.Text = "Mapa Esquematico";
            showMapButton.UseVisualStyleBackColor = true;
            showMapButton.Click += showMapButton_Click;
            // 
            // instructionLBox
            // 
            instructionLBox.FormattingEnabled = true;
            instructionLBox.Location = new Point(12, 136);
            instructionLBox.Margin = new Padding(5);
            instructionLBox.Name = "instructionLBox";
            instructionLBox.Size = new Size(224, 394);
            instructionLBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(8, 5);
            statusLabel.Margin = new Padding(5, 5, 5, 15);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(141, 15);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Bienvenido! Elija 2 nodos:";
            // 
            // buscarButton
            // 
            buscarButton.Location = new Point(62, 103);
            buscarButton.Margin = new Padding(5);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(174, 23);
            buscarButton.TabIndex = 4;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += buscarButton_Click;
            // 
            // haciaLabel
            // 
            haciaLabel.AutoSize = true;
            haciaLabel.Location = new Point(12, 73);
            haciaLabel.Margin = new Padding(5);
            haciaLabel.Name = "haciaLabel";
            haciaLabel.Size = new Size(40, 15);
            haciaLabel.TabIndex = 3;
            haciaLabel.Text = "Hacia:";
            // 
            // desdeLabel
            // 
            desdeLabel.AutoSize = true;
            desdeLabel.Location = new Point(10, 40);
            desdeLabel.Margin = new Padding(5);
            desdeLabel.Name = "desdeLabel";
            desdeLabel.Size = new Size(42, 15);
            desdeLabel.TabIndex = 2;
            desdeLabel.Text = "Desde:";
            // 
            // haciaComboBox
            // 
            haciaComboBox.FormattingEnabled = true;
            haciaComboBox.Location = new Point(62, 70);
            haciaComboBox.Margin = new Padding(5);
            haciaComboBox.Name = "haciaComboBox";
            haciaComboBox.Size = new Size(174, 23);
            haciaComboBox.TabIndex = 1;
            // 
            // desdeComboBox
            // 
            desdeComboBox.FormattingEnabled = true;
            desdeComboBox.Location = new Point(62, 37);
            desdeComboBox.Margin = new Padding(5);
            desdeComboBox.Name = "desdeComboBox";
            desdeComboBox.Size = new Size(174, 23);
            desdeComboBox.TabIndex = 0;
            // 
            // viewerPanel
            // 
            viewerPanel.Controls.Add(gViewer1);
            viewerPanel.Dock = DockStyle.Fill;
            viewerPanel.Location = new Point(0, 0);
            viewerPanel.Name = "viewerPanel";
            viewerPanel.Size = new Size(708, 636);
            viewerPanel.TabIndex = 1;
            // 
            // gViewer1
            // 
            gViewer1.ArrowheadLength = 0D;
            gViewer1.AsyncLayout = false;
            gViewer1.AutoScroll = true;
            gViewer1.BackwardEnabled = false;
            gViewer1.BuildHitTree = true;
            gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.MDS;
            gViewer1.Dock = DockStyle.Fill;
            gViewer1.EdgeInsertButtonVisible = false;
            gViewer1.FileName = "";
            gViewer1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gViewer1.ForwardEnabled = false;
            gViewer1.Graph = null;
            gViewer1.IncrementalDraggingModeAlways = false;
            gViewer1.InsertingEdge = false;
            gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
            gViewer1.LayoutEditingEnabled = false;
            gViewer1.Location = new Point(0, 0);
            gViewer1.LooseOffsetForRouting = 0.25D;
            gViewer1.MouseHitDistance = 0.05D;
            gViewer1.Name = "gViewer1";
            gViewer1.NavigationVisible = false;
            gViewer1.NeedToCalculateLayout = true;
            gViewer1.OffsetForRelaxingInRouting = 0.6D;
            gViewer1.PaddingForEdgeRouting = 8D;
            gViewer1.PanButtonPressed = false;
            gViewer1.SaveAsImageEnabled = false;
            gViewer1.SaveAsMsaglEnabled = false;
            gViewer1.SaveButtonVisible = false;
            gViewer1.SaveGraphButtonVisible = false;
            gViewer1.SaveInVectorFormatEnabled = false;
            gViewer1.Size = new Size(708, 636);
            gViewer1.TabIndex = 0;
            gViewer1.TightOffsetForRouting = 0.125D;
            gViewer1.ToolBarIsVisible = true;
            gViewer1.Transform = (Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)resources.GetObject("gViewer1.Transform");
            gViewer1.UndoRedoButtonsVisible = false;
            gViewer1.WindowZoomButtonPressed = false;
            gViewer1.ZoomF = 1D;
            gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 636);
            Controls.Add(viewerPanel);
            Controls.Add(toolsPanel);
            Name = "Form1";
            Text = "Proyecto Final";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            toolsPanel.ResumeLayout(false);
            toolsPanel.PerformLayout();
            viewerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel toolsPanel;
        private Panel viewerPanel;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private ComboBox haciaComboBox;
        private ComboBox desdeComboBox;
        private Label haciaLabel;
        private Label desdeLabel;
        private Label statusLabel;
        private Button buscarButton;
        private ListBox instructionLBox;
        private Button showMapButton;
    }
}
