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

        private PictureBox current_cell;

        private enum cell_type
        {
            empty, floor,
            top, right, bottom, left,
            top_right_outter_corner, bottom_right_outter_corner, bottom_left_outter_corner, top_left_outter_corner,
            top_right_inner_corner, bottom_right_inner_corner, bottom_left_inner_corner, top_left_inner_corner
        };

        private Color[] cell_colors = {
           Color.White,
           Color.Blue,

           Color.LightPink,
           Color.Coral,
           Color.DarkKhaki,
           Color.Chartreuse,

           Color.Fuchsia,
           Color.Firebrick,
           Color.PaleGreen,
           Color.Lavender,

           Color.Black,
           Color.SeaGreen,
           Color.YellowGreen,
           Color.Orange
        };

        public Form1()
        {
            InitializeComponent();
            cells = new List<PictureBox>();
            current_cell = null;
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
                    newBox.MouseEnter += new System.EventHandler(this.highlightSelection);
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

                if (cell.BackColor == cell_colors[0]) map_string += "0";
                else if (cell.BackColor == cell_colors[1]) map_string += "1";
                else if (cell.BackColor == cell_colors[2]) map_string += "2";
                else if (cell.BackColor == cell_colors[3]) map_string += "3";
                else if (cell.BackColor == cell_colors[4]) map_string += "4";
                else if (cell.BackColor == cell_colors[5]) map_string += "5";
                else if (cell.BackColor == cell_colors[6]) map_string += "6";
                else if (cell.BackColor == cell_colors[7]) map_string += "7";
                else if (cell.BackColor == cell_colors[8]) map_string += "8";
                else if (cell.BackColor == cell_colors[9]) map_string += "9";
                else if (cell.BackColor == cell_colors[10]) map_string += "A";
                else if (cell.BackColor == cell_colors[11]) map_string += "B";
                else if (cell.BackColor == cell_colors[12]) map_string += "C";
                else if (cell.BackColor == cell_colors[13]) map_string += "D";

                map_string += ' ';
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

        private void highlightSelection(object sender, EventArgs e)
        {
            if (current_cell != null)
            {
                clearHighlight(current_cell);
            }

            current_cell = (PictureBox)sender;
         
            PictureBox cell = (PictureBox)sender;
            cell.BorderStyle = BorderStyle.FixedSingle;
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

        private int getIndexAt(int x, int y)
        {
            return (y * current_width) + x;
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

            //if((a_x >= b_x && a_y < b_y) || () )

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

        public void clearHighlight( PictureBox cell)
        {
            cell.BorderStyle = BorderStyle.None;
        }

        private void wallCreateButton_Click(object sender, EventArgs e)
        {
            int current_index = 0;
            int select_index = 0;
            foreach (PictureBox cell in cells)
            {
                if (cell.BackColor == Color.Blue)
                {
                    current_index = cells.IndexOf(cell);

                    int a_x = current_index % current_width;
                    int a_y = (int)Math.Ceiling((double)(current_index / current_width));

                    PictureBox cell_left = cells[getIndexAt(a_x - 1, a_y)];
                    PictureBox cell_right = cells[getIndexAt(a_x + 1, a_y)];
                    PictureBox cell_top = cells[getIndexAt(a_x, a_y - 1)];
                    PictureBox cell_bottom = cells[getIndexAt(a_x, a_y + 1)];

                    cell_type code = getTileCode(cell_left, cell_right, cell_top, cell_bottom);

                    

                    switch(code)
                    {
                        // walls
                        case(cell_type.top):
                            if (cell_top.BackColor == cell_colors[(int)cell_type.left])
                            {
                                cell_top.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                            }

                            else if (cell_top.BackColor == cell_colors[(int)cell_type.right])
                            {
                                cell_top.BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                            }

                            else if(cell_top.BackColor == cell_colors[(int)cell_type.empty]) cell_top.BackColor = cell_colors[(int)cell_type.top];
                            break;

                        case (cell_type.right):
                            if (cell_right.BackColor == cell_colors[(int)cell_type.top])
                            {
                                cell_right.BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                            }

                            else if (cell_right.BackColor == cell_colors[(int)cell_type.bottom])
                            {
                                cell_right.BackColor = cell_colors[(int)cell_type.top_left_inner_corner];
                            }

                            else if (cell_right.BackColor == cell_colors[(int)cell_type.empty]) cell_right.BackColor = cell_colors[(int)cell_type.right];
                            break;

                        case (cell_type.bottom):
                            if (cell_bottom.BackColor == cell_colors[(int)cell_type.left])
                            {
                                cell_bottom.BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                            }

                            else if (cell_bottom.BackColor == cell_colors[(int)cell_type.right])
                            {
                                cell_bottom.BackColor = cell_colors[(int)cell_type.top_left_inner_corner];
                            }

                            else if(cell_bottom.BackColor == cell_colors[(int)cell_type.empty]) cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                            break;

                        case(cell_type.left):
                            if (cell_left.BackColor == cell_colors[(int)cell_type.top])
                            {
                                cell_right.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                            }

                            else if (cell_left.BackColor == cell_colors[(int)cell_type.bottom])
                            {
                                cell_left.BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                            }

                            else if (cell_left.BackColor == cell_colors[(int)cell_type.empty]) cell_left.BackColor = cell_colors[(int)cell_type.left];
                            break;
                        // outter corners
                        case(cell_type.top_right_outter_corner):
                            cells[getIndexAt(a_x + 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_right_outter_corner];
                            cell_top.BackColor = cell_colors[(int)cell_type.top];
                            cell_right.BackColor = cell_colors[(int)cell_type.right];
                            break;

                        case(cell_type.bottom_right_outter_corner):
                            cells[getIndexAt(a_x + 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_right_outter_corner];
                            cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                            cell_right.BackColor = cell_colors[(int)cell_type.right];
                            break;

                        case(cell_type.bottom_left_outter_corner):
                            cells[getIndexAt(a_x - 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_left_outter_corner];
                            cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                            cell_left.BackColor = cell_colors[(int)cell_type.left];
                            break;

                        case(cell_type.top_left_outter_corner):
                            cells[getIndexAt(a_x - 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_left_outter_corner];
                            cell_top.BackColor = cell_colors[(int)cell_type.top];
                            cell_left.BackColor = cell_colors[(int)cell_type.left];
                            break;
                    }
                }
            }
            fixInnerCorners();
        }

        private void fixInnerCorners()
        {
            int current_index = 0;
            int select_index = 0;
            foreach (PictureBox cell in cells)
            {
                if (cell.BackColor != cell_colors[(int)cell_type.floor] && cell.BackColor != cell_colors[(int)cell_type.empty])
                {
                    current_index = cells.IndexOf(cell);

                    int a_x = current_index % current_width;
                    int a_y = (int)Math.Ceiling((double)(current_index / current_width));

                    PictureBox cell_left = cells[getIndexAt(a_x - 1, a_y)];
                    PictureBox cell_right = cells[getIndexAt(a_x + 1, a_y)];
                    PictureBox cell_top = cells[getIndexAt(a_x, a_y - 1)];
                    PictureBox cell_bottom = cells[getIndexAt(a_x, a_y + 1)];

                    if ((cell_top.BackColor == cell_colors[(int)cell_type.right] || cell_top.BackColor == cell_colors[(int)cell_type.top_right_outter_corner]) &&
                         (cell_right.BackColor == cell_colors[(int)cell_type.top] || cell_right.BackColor == cell_colors[(int)cell_type.top_right_outter_corner]))
                    {
                        cell.BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                    }

                    else if ((cell_bottom.BackColor == cell_colors[(int)cell_type.right] || cell_bottom.BackColor == cell_colors[(int)cell_type.bottom_right_outter_corner]) &&
                         (cell_right.BackColor == cell_colors[(int)cell_type.bottom] || cell_right.BackColor == cell_colors[(int)cell_type.bottom_right_outter_corner]))
                    {
                        cell.BackColor = cell_colors[(int)cell_type.top_left_inner_corner];
                    }

                    else if ((cell_bottom.BackColor == cell_colors[(int)cell_type.left] || cell_bottom.BackColor == cell_colors[(int)cell_type.bottom_left_outter_corner]) &&
                         (cell_left.BackColor == cell_colors[(int)cell_type.bottom] || cell_left.BackColor == cell_colors[(int)cell_type.bottom_left_outter_corner]))
                    {
                        cell.BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                    }

                    else if ((cell_top.BackColor == cell_colors[(int)cell_type.left] || cell_top.BackColor == cell_colors[(int)cell_type.top_left_outter_corner]) &&
                         (cell_left.BackColor == cell_colors[(int)cell_type.top] || cell_left.BackColor == cell_colors[(int)cell_type.top_left_outter_corner]))
                    {
                        cell.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                    }

                }
            }

        }

        private cell_type getTileCode(PictureBox cell_left, PictureBox cell_right, PictureBox cell_top, PictureBox cell_bottom)
        {
            // no walls
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.empty;
            }

            // top wall
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.top;
            }

            // right wall
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.right;
            }

            // bottom wall
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.bottom;
            }

            // left wall
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.left;
            }

            // top right outter corner
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.top_right_outter_corner;
            }

            // bottom right outter corner
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.bottom_right_outter_corner;
            }

            // bottom left outter corner
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.bottom_left_outter_corner;
            }

            // top left outter corner
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.top_left_outter_corner;
            }

            return cell_type.empty;
        }
    }
}
