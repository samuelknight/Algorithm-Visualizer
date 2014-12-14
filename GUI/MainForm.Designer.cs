namespace AlgorithmVisualizer.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sandboxSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ConsoleOuput = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenueStrip = new System.Windows.Forms.MenuStrip();
            this.newNodeToolButton = new System.Windows.Forms.Button();
            this.Sandbox = new AlgorithmVisualizer.GUI.AnimatedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sandboxSplitContainer)).BeginInit();
            this.sandboxSplitContainer.Panel1.SuspendLayout();
            this.sandboxSplitContainer.Panel2.SuspendLayout();
            this.sandboxSplitContainer.SuspendLayout();
            this.mainMenueStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sandbox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sandboxSplitContainer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.ConsoleOuput);
            this.splitContainer.Size = new System.Drawing.Size(820, 564);
            this.splitContainer.SplitterDistance = 336;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            this.splitContainer.Resize += new System.EventHandler(this.splitContainer_Resize);
            // 
            // sandboxSplitContainer
            // 
            this.sandboxSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sandboxSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.sandboxSplitContainer.Name = "sandboxSplitContainer";
            // 
            // sandboxSplitContainer.Panel1
            // 
            this.sandboxSplitContainer.Panel1.Controls.Add(this.newNodeToolButton);
            this.sandboxSplitContainer.Panel1MinSize = 0;
            // 
            // sandboxSplitContainer.Panel2
            // 
            this.sandboxSplitContainer.Panel2.Controls.Add(this.Sandbox);
            this.sandboxSplitContainer.Size = new System.Drawing.Size(820, 339);
            this.sandboxSplitContainer.SplitterDistance = 58;
            this.sandboxSplitContainer.TabIndex = 1;
            // 
            // ConsoleOuput
            // 
            this.ConsoleOuput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleOuput.BackColor = System.Drawing.Color.Black;
            this.ConsoleOuput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleOuput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleOuput.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleOuput.Location = new System.Drawing.Point(0, -1);
            this.ConsoleOuput.Name = "ConsoleOuput";
            this.ConsoleOuput.Size = new System.Drawing.Size(820, 247);
            this.ConsoleOuput.TabIndex = 0;
            this.ConsoleOuput.Text = "Console Output";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entitiesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.entitiesToolStripMenuItem.Text = "Entities";
            this.entitiesToolStripMenuItem.Click += new System.EventHandler(this.entitiesToolStripMenuItem_Click);
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // mainMenueStrip
            // 
            this.mainMenueStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.algorithmToolStripMenuItem});
            this.mainMenueStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenueStrip.Name = "mainMenueStrip";
            this.mainMenueStrip.Size = new System.Drawing.Size(820, 24);
            this.mainMenueStrip.TabIndex = 2;
            this.mainMenueStrip.Text = "menuStrip1";
            // 
            // newNodeToolButton
            // 
            this.newNodeToolButton.BackColor = System.Drawing.Color.Gray;
            this.newNodeToolButton.BackgroundImage = global::AlgorithmVisualizer.Properties.Resources.NewNodeTool;
            this.newNodeToolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newNodeToolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNodeToolButton.Location = new System.Drawing.Point(9, 9);
            this.newNodeToolButton.Margin = new System.Windows.Forms.Padding(9);
            this.newNodeToolButton.Name = "newNodeToolButton";
            this.newNodeToolButton.Size = new System.Drawing.Size(32, 32);
            this.newNodeToolButton.TabIndex = 0;
            this.newNodeToolButton.UseVisualStyleBackColor = false;
            // 
            // Sandbox
            // 
            this.Sandbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sandbox.BackColor = System.Drawing.Color.Silver;
            this.Sandbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sandbox.Location = new System.Drawing.Point(-3, -1);
            this.Sandbox.Name = "Sandbox";
            this.Sandbox.Size = new System.Drawing.Size(767, 340);
            this.Sandbox.TabIndex = 0;
            this.Sandbox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 588);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenueStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenueStrip;
            this.Name = "MainForm";
            this.Text = "Algorithm Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.sandboxSplitContainer.Panel1.ResumeLayout(false);
            this.sandboxSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sandboxSplitContainer)).EndInit();
            this.sandboxSplitContainer.ResumeLayout(false);
            this.mainMenueStrip.ResumeLayout(false);
            this.mainMenueStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sandbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnimatedPictureBox Sandbox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox ConsoleOuput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenueStrip;
        private System.Windows.Forms.SplitContainer sandboxSplitContainer;
        private System.Windows.Forms.Button newNodeToolButton;
    }
}

