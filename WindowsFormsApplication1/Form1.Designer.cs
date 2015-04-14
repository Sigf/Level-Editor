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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xValuePicker = new System.Windows.Forms.NumericUpDown();
            this.yValuePicker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.current_selection_box = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cellSizePicker = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.fileCreateButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.rectangleMode = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xValuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_selection_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "by";
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(15, 32);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tile Selection:";
            // 
            // xValuePicker
            // 
            this.xValuePicker.Location = new System.Drawing.Point(79, 7);
            this.xValuePicker.Name = "xValuePicker";
            this.xValuePicker.Size = new System.Drawing.Size(50, 20);
            this.xValuePicker.TabIndex = 7;
            this.xValuePicker.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // yValuePicker
            // 
            this.yValuePicker.Location = new System.Drawing.Point(160, 7);
            this.yValuePicker.Name = "yValuePicker";
            this.yValuePicker.Size = new System.Drawing.Size(50, 20);
            this.yValuePicker.TabIndex = 8;
            this.yValuePicker.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Currently Selected:";
            // 
            // current_selection_box
            // 
            this.current_selection_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.current_selection_box.Location = new System.Drawing.Point(216, 32);
            this.current_selection_box.Name = "current_selection_box";
            this.current_selection_box.Size = new System.Drawing.Size(23, 23);
            this.current_selection_box.TabIndex = 10;
            this.current_selection_box.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cell Size:";
            // 
            // cellSizePicker
            // 
            this.cellSizePicker.Location = new System.Drawing.Point(313, 35);
            this.cellSizePicker.Name = "cellSizePicker";
            this.cellSizePicker.Size = new System.Drawing.Size(47, 20);
            this.cellSizePicker.TabIndex = 12;
            this.cellSizePicker.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(313, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Empty Space");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(340, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox2, "Wall");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(366, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox3, "Floor");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(392, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.toolTip4.SetToolTip(this.pictureBox4, "Vertical Door");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // fileCreateButton
            // 
            this.fileCreateButton.Location = new System.Drawing.Point(452, 32);
            this.fileCreateButton.Name = "fileCreateButton";
            this.fileCreateButton.Size = new System.Drawing.Size(75, 23);
            this.fileCreateButton.TabIndex = 17;
            this.fileCreateButton.Text = "Create File";
            this.fileCreateButton.UseVisualStyleBackColor = true;
            this.fileCreateButton.Click += new System.EventHandler(this.fileCreateButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(371, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // rectangleMode
            // 
            this.rectangleMode.AutoSize = true;
            this.rectangleMode.Location = new System.Drawing.Point(564, 3);
            this.rectangleMode.Name = "rectangleMode";
            this.rectangleMode.Size = new System.Drawing.Size(133, 17);
            this.rectangleMode.TabIndex = 19;
            this.rectangleMode.Text = "Rectangle Draw Mode";
            this.rectangleMode.UseVisualStyleBackColor = true;
            this.rectangleMode.CheckedChanged += new System.EventHandler(this.rectangleMode_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Lime;
            this.pictureBox5.Location = new System.Drawing.Point(418, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.toolTip5.SetToolTip(this.pictureBox5, "Horizontal Door");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(773, 331);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.rectangleMode);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fileCreateButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cellSizePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.current_selection_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yValuePicker);
            this.Controls.Add(this.xValuePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Room Maker";
            ((System.ComponentModel.ISupportInitialize)(this.xValuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_selection_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown xValuePicker;
        private System.Windows.Forms.NumericUpDown yValuePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox current_selection_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cellSizePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button fileCreateButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox rectangleMode;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}

