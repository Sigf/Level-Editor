namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleDrawModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outterCornersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innerCornersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomRightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLeftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rectangleModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.current_selection_box = new System.Windows.Forms.ToolStripStatusLabel();
            this.openRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewRoomToolStripMenuItem,
            this.exportRoomToolStripMenuItem,
            this.openRoomToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewRoomToolStripMenuItem
            // 
            this.createNewRoomToolStripMenuItem.Name = "createNewRoomToolStripMenuItem";
            this.createNewRoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewRoomToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.createNewRoomToolStripMenuItem.Text = "Create New Room";
            this.createNewRoomToolStripMenuItem.Click += new System.EventHandler(this.createNewRoomToolStripMenuItem_Click);
            // 
            // exportRoomToolStripMenuItem
            // 
            this.exportRoomToolStripMenuItem.Name = "exportRoomToolStripMenuItem";
            this.exportRoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportRoomToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exportRoomToolStripMenuItem.Text = "Export Room";
            this.exportRoomToolStripMenuItem.Click += new System.EventHandler(this.exportRoomToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleDrawModeToolStripMenuItem,
            this.generateWallsToolStripMenuItem,
            this.clearRoomToolStripMenuItem,
            this.clearWallsToolStripMenuItem,
            this.selectTileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // rectangleDrawModeToolStripMenuItem
            // 
            this.rectangleDrawModeToolStripMenuItem.Name = "rectangleDrawModeToolStripMenuItem";
            this.rectangleDrawModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.rectangleDrawModeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.rectangleDrawModeToolStripMenuItem.Text = "Rectangle Draw Mode";
            this.rectangleDrawModeToolStripMenuItem.Click += new System.EventHandler(this.rectangleDrawModeToolStripMenuItem_Click);
            // 
            // generateWallsToolStripMenuItem
            // 
            this.generateWallsToolStripMenuItem.Name = "generateWallsToolStripMenuItem";
            this.generateWallsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.generateWallsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.generateWallsToolStripMenuItem.Text = "Generate Walls";
            this.generateWallsToolStripMenuItem.Click += new System.EventHandler(this.generateWallsToolStripMenuItem_Click);
            // 
            // clearRoomToolStripMenuItem
            // 
            this.clearRoomToolStripMenuItem.Name = "clearRoomToolStripMenuItem";
            this.clearRoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.clearRoomToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.clearRoomToolStripMenuItem.Text = "Clear Room";
            this.clearRoomToolStripMenuItem.Click += new System.EventHandler(this.clearRoomToolStripMenuItem_Click);
            // 
            // selectTileToolStripMenuItem
            // 
            this.selectTileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem,
            this.floorToolStripMenuItem,
            this.wallToolStripMenuItem});
            this.selectTileToolStripMenuItem.Name = "selectTileToolStripMenuItem";
            this.selectTileToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.selectTileToolStripMenuItem.Text = "Select Tile";
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // floorToolStripMenuItem
            // 
            this.floorToolStripMenuItem.Name = "floorToolStripMenuItem";
            this.floorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.floorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.floorToolStripMenuItem.Text = "Floor";
            this.floorToolStripMenuItem.Click += new System.EventHandler(this.floorToolStripMenuItem_Click);
            // 
            // wallToolStripMenuItem
            // 
            this.wallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.outterCornersToolStripMenuItem,
            this.innerCornersToolStripMenuItem});
            this.wallToolStripMenuItem.Name = "wallToolStripMenuItem";
            this.wallToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.wallToolStripMenuItem.Text = "Wall";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem1,
            this.rightToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.leftToolStripMenuItem});
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.topToolStripMenuItem.Text = "Flat";
            // 
            // topToolStripMenuItem1
            // 
            this.topToolStripMenuItem1.Name = "topToolStripMenuItem1";
            this.topToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.topToolStripMenuItem1.Text = "Top";
            this.topToolStripMenuItem1.Click += new System.EventHandler(this.topToolStripMenuItem1_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bottomToolStripMenuItem.Text = "Bottom";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.bottomToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // outterCornersToolStripMenuItem
            // 
            this.outterCornersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topRightToolStripMenuItem,
            this.bottomRightToolStripMenuItem,
            this.bottomLeftToolStripMenuItem,
            this.topLeftToolStripMenuItem});
            this.outterCornersToolStripMenuItem.Name = "outterCornersToolStripMenuItem";
            this.outterCornersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outterCornersToolStripMenuItem.Text = "Outter Corners";
            // 
            // topRightToolStripMenuItem
            // 
            this.topRightToolStripMenuItem.Name = "topRightToolStripMenuItem";
            this.topRightToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.topRightToolStripMenuItem.Text = "Top-Right";
            this.topRightToolStripMenuItem.Click += new System.EventHandler(this.topRightToolStripMenuItem_Click);
            // 
            // bottomRightToolStripMenuItem
            // 
            this.bottomRightToolStripMenuItem.Name = "bottomRightToolStripMenuItem";
            this.bottomRightToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.bottomRightToolStripMenuItem.Text = "Bottom-Right";
            this.bottomRightToolStripMenuItem.Click += new System.EventHandler(this.bottomRightToolStripMenuItem_Click);
            // 
            // bottomLeftToolStripMenuItem
            // 
            this.bottomLeftToolStripMenuItem.Name = "bottomLeftToolStripMenuItem";
            this.bottomLeftToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.bottomLeftToolStripMenuItem.Text = "Bottom-Left";
            this.bottomLeftToolStripMenuItem.Click += new System.EventHandler(this.bottomLeftToolStripMenuItem_Click);
            // 
            // topLeftToolStripMenuItem
            // 
            this.topLeftToolStripMenuItem.Name = "topLeftToolStripMenuItem";
            this.topLeftToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.topLeftToolStripMenuItem.Text = "Top-Left";
            this.topLeftToolStripMenuItem.Click += new System.EventHandler(this.topLeftToolStripMenuItem_Click);
            // 
            // innerCornersToolStripMenuItem
            // 
            this.innerCornersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topRightToolStripMenuItem1,
            this.bottomRightToolStripMenuItem1,
            this.bottomLeftToolStripMenuItem1,
            this.topLeftToolStripMenuItem1});
            this.innerCornersToolStripMenuItem.Name = "innerCornersToolStripMenuItem";
            this.innerCornersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.innerCornersToolStripMenuItem.Text = "Inner Corners";
            // 
            // topRightToolStripMenuItem1
            // 
            this.topRightToolStripMenuItem1.Name = "topRightToolStripMenuItem1";
            this.topRightToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.topRightToolStripMenuItem1.Text = "Top-Right";
            this.topRightToolStripMenuItem1.Click += new System.EventHandler(this.topRightToolStripMenuItem1_Click);
            // 
            // bottomRightToolStripMenuItem1
            // 
            this.bottomRightToolStripMenuItem1.Name = "bottomRightToolStripMenuItem1";
            this.bottomRightToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.bottomRightToolStripMenuItem1.Text = "Bottom-Right";
            this.bottomRightToolStripMenuItem1.Click += new System.EventHandler(this.bottomRightToolStripMenuItem1_Click);
            // 
            // bottomLeftToolStripMenuItem1
            // 
            this.bottomLeftToolStripMenuItem1.Name = "bottomLeftToolStripMenuItem1";
            this.bottomLeftToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.bottomLeftToolStripMenuItem1.Text = "Bottom-Left";
            this.bottomLeftToolStripMenuItem1.Click += new System.EventHandler(this.bottomLeftToolStripMenuItem1_Click);
            // 
            // topLeftToolStripMenuItem1
            // 
            this.topLeftToolStripMenuItem1.Name = "topLeftToolStripMenuItem1";
            this.topLeftToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.topLeftToolStripMenuItem1.Text = "Top-Left";
            this.topLeftToolStripMenuItem1.Click += new System.EventHandler(this.topLeftToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleModeStatus,
            this.current_selection_box});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rectangleModeStatus
            // 
            this.rectangleModeStatus.Name = "rectangleModeStatus";
            this.rectangleModeStatus.Size = new System.Drawing.Size(120, 17);
            this.rectangleModeStatus.Text = "Rectangle Mode: OFF";
            // 
            // current_selection_box
            // 
            this.current_selection_box.BackColor = System.Drawing.Color.White;
            this.current_selection_box.Name = "current_selection_box";
            this.current_selection_box.Size = new System.Drawing.Size(16, 17);
            this.current_selection_box.Text = "   ";
            // 
            // openRoomToolStripMenuItem
            // 
            this.openRoomToolStripMenuItem.Name = "openRoomToolStripMenuItem";
            this.openRoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openRoomToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openRoomToolStripMenuItem.Text = "Open Room";
            this.openRoomToolStripMenuItem.Click += new System.EventHandler(this.openRoomToolStripMenuItem_Click);
            // 
            // clearWallsToolStripMenuItem
            // 
            this.clearWallsToolStripMenuItem.Name = "clearWallsToolStripMenuItem";
            this.clearWallsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.clearWallsToolStripMenuItem.Text = "Clear Walls";
            this.clearWallsToolStripMenuItem.Click += new System.EventHandler(this.clearWallsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(773, 498);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Room Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleDrawModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateWallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outterCornersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innerCornersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bottomRightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bottomLeftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel rectangleModeStatus;
        private System.Windows.Forms.ToolStripStatusLabel current_selection_box;
        private System.Windows.Forms.ToolStripMenuItem openRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearWallsToolStripMenuItem;
    }
}

