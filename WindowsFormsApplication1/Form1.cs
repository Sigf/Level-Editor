using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Color selected_color = Color.White;

        public List<PictureBox> cells;

        private int pointOne;
        private int PointTwo;

        private bool clickedOnce = false;

        private int current_width = 0;
        private int current_height = 0;

        public Form1()
        {
            InitializeComponent();
            cells = new List<PictureBox>();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            int x_count = (int)xValuePicker.Value;
            int y_count = (int)yValuePicker.Value;
            current_height = y_count;
            current_width = x_count;
            int size = (int)cellSizePicker.Value;
            AddCell(x_count, y_count, size);
        }

        public void AddCell(int column, int row, int size)
        {
            //System.Drawing.Point origin = room_layout.Location;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    System.Windows.Forms.PictureBox newBox = new System.Windows.Forms.PictureBox();
                    newBox.Name = "cell";
                    newBox.Top = 61 + (i*size);
                    newBox.Left = 15 + (j*size);
                    newBox.Size = new System.Drawing.Size(size, size);
                    newBox.BackColor = Color.White;
                    newBox.BringToFront();
                    this.Controls.Add(newBox);
                    cells.Add(newBox);
                    newBox.Click += new System.EventHandler(this.handleCellClick);
                }
            }
        }

        public void CreateFile()
        {
            string file_name = "";
            System.IO.StreamWriter objWriter;
            System.Windows.Forms.DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file_name = openFileDialog1.FileName;
            }

            objWriter = new System.IO.StreamWriter(file_name);

            string map_string = "";

            int count = 0;
            int width = (int)xValuePicker.Value;

            foreach (Control cell in cells)
            {
                if (count % width == 0 && count != 0) map_string += "\r\n";

                if (cell.BackColor == Color.White) map_string += "0";
                else if (cell.BackColor == Color.Red) map_string += "1";
                else if (cell.BackColor == Color.Blue) map_string += "2";
                else if (cell.BackColor == Color.Yellow) map_string += "3";
                else if (cell.BackColor == Color.Lime) map_string += "4";
                count++;
            }

            //Debug.WriteLine(map_string);
            objWriter.Write(map_string);
            objWriter.Close();
        }

        private void handleCellClick(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;

            //Debug.Write("Click!");

            if (rectangleMode.Checked == true)
            {
                if (clickedOnce == false)
                {
                    pointOne = cells.IndexOf(cell);
                    clickedOnce = true;
                }

                else
                {
                    PointTwo = cells.IndexOf(cell);
                    printRectangle();
                }
            }

            cell.BackColor = selected_color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selected_color = Color.White;
            current_selection_box.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selected_color = Color.Red;
            current_selection_box.BackColor = Color.Red;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selected_color = Color.Blue;
            current_selection_box.BackColor = Color.Blue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selected_color = Color.Yellow;
            current_selection_box.BackColor = Color.Yellow;
        }

        private void fileCreateButton_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control cell in cells)
            {
                cell.BackColor = Color.White;
            }
        }

        private void rectangleMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selected_color = Color.Lime;
            current_selection_box.BackColor = Color.Lime;
        }

        public void printRectangle()
        {

            int a_x = pointOne % current_width;
            int a_y = (int)Math.Ceiling((double)(pointOne / current_width));

            int b_x = PointTwo % current_width;
            int b_y = (int)Math.Ceiling((double)(PointTwo / current_width));

            Debug.WriteLine("point1:(" + a_x + "," + a_y + ")");
            Debug.WriteLine("point2:(" + b_x + "," + b_y + ")");

            int width = Math.Abs(a_x - b_x);
            int height = Math.Abs(a_y - b_y);

            int origin = pointOne < PointTwo ? pointOne : PointTwo;

            for (int i = 0; i < height + 1; i++)
            {
                for (int j = 0; j < width + 1; j++)
                {
                    int index = ((origin + j) + (i*current_width));
                    PictureBox cell = cells.ElementAt(index);
                    cell.BackColor = selected_color;
                }
            }
                clickedOnce = false;
        }
    }
}
