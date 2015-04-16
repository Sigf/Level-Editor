namespace WindowsFormsApplication1
{
    partial class NewRoomForm
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
            this.yValuePicker = new System.Windows.Forms.NumericUpDown();
            this.xValuePicker = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.cellSizePicker = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yValuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // yValuePicker
            // 
            this.yValuePicker.Location = new System.Drawing.Point(183, 17);
            this.yValuePicker.Name = "yValuePicker";
            this.yValuePicker.Size = new System.Drawing.Size(50, 20);
            this.yValuePicker.TabIndex = 12;
            this.yValuePicker.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // xValuePicker
            // 
            this.xValuePicker.Location = new System.Drawing.Point(102, 17);
            this.xValuePicker.Name = "xValuePicker";
            this.xValuePicker.Size = new System.Drawing.Size(50, 20);
            this.xValuePicker.TabIndex = 11;
            this.xValuePicker.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room Size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(38, 72);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 13;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // cellSizePicker
            // 
            this.cellSizePicker.Location = new System.Drawing.Point(102, 41);
            this.cellSizePicker.Name = "cellSizePicker";
            this.cellSizePicker.Size = new System.Drawing.Size(50, 20);
            this.cellSizePicker.TabIndex = 15;
            this.cellSizePicker.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cell Size:";
            // 
            // NewRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 118);
            this.Controls.Add(this.cellSizePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.yValuePicker);
            this.Controls.Add(this.xValuePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewRoomForm";
            this.Text = "Create Room";
            this.Load += new System.EventHandler(this.NewRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yValuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown yValuePicker;
        private System.Windows.Forms.NumericUpDown xValuePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.NumericUpDown cellSizePicker;
        private System.Windows.Forms.Label label5;
    }
}