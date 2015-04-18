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
            this.openRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleDrawModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rectangleModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.current_selection_box = new System.Windows.Forms.ToolStripStatusLabel();
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
            // openRoomToolStripMenuItem
            // 
            this.openRoomToolStripMenuItem.Name = "openRoomToolStripMenuItem";
            this.openRoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openRoomToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openRoomToolStripMenuItem.Text = "Open Room";
            this.openRoomToolStripMenuItem.Click += new System.EventHandler(this.openRoomToolStripMenuItem_Click);
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
            // clearWallsToolStripMenuItem
            // 
            this.clearWallsToolStripMenuItem.Name = "clearWallsToolStripMenuItem";
            this.clearWallsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.clearWallsToolStripMenuItem.Text = "Clear Walls";
            this.clearWallsToolStripMenuItem.Click += new System.EventHandler(this.clearWallsToolStripMenuItem_Click);
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
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // floorToolStripMenuItem
            // 
            this.floorToolStripMenuItem.Name = "floorToolStripMenuItem";
            this.floorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.floorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.floorToolStripMenuItem.Text = "Floor";
            this.floorToolStripMenuItem.Click += new System.EventHandler(this.floorToolStripMenuItem_Click);
            // 
            // wallToolStripMenuItem
            // 
            this.wallToolStripMenuItem.Name = "wallToolStripMenuItem";
            this.wallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wallToolStripMenuItem.Text = "Tile Picker";
            this.wallToolStripMenuItem.Click += new System.EventHandler(this.wallToolStripMenuItem_Click);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel rectangleModeStatus;
        private System.Windows.Forms.ToolStripStatusLabel current_selection_box;
        private System.Windows.Forms.ToolStripMenuItem openRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearWallsToolStripMenuItem;
    }
}

