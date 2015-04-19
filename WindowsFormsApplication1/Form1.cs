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

        private List<List<PictureBox>> undo_stack;
        private int undo_index = -1;
        private int undo_max = 15;

        private int pointOne;
        private int PointTwo;

        private bool clickedOnce = false;

        private int current_width = 0;
        private int current_height = 0;
        private int current_cell_size = 0;

        private PictureBox current_cell;

        private bool rectanlgeMode_checked = false;

        public enum cell_type
        {
            empty, floor,
            top, right, bottom, left,
            top_right_outter_corner, bottom_right_outter_corner, bottom_left_outter_corner, top_left_outter_corner,
            top_right_inner_corner, bottom_right_inner_corner, bottom_left_inner_corner, top_left_inner_corner,
            top_and_bottom, left_and_right,
            top_cul, right_cul, bottom_cul, left_cul
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
            undo_stack = new List<List<PictureBox>>();
            current_cell = null;
        }

        public void createRoom(int x_count, int y_count, int size)
        {
            removeCanvas();
            current_height = y_count;
            current_width = x_count;
            current_cell_size = size;
            createCanvas(x_count, y_count, size);
            backup();
        }

        public void createCanvas(int column, int row, int size)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    System.Windows.Forms.PictureBox newBox = new System.Windows.Forms.PictureBox();
                    newBox.Name = "cell";
                    newBox.Top = 27 + (i*size);
                    newBox.Left = 12 + (j*size);
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

        public void loadMap()
        {
            string file_name = "";
            System.IO.StreamReader objReader;
            System.Windows.Forms.DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file_name = openFileDialog1.FileName;
            }

            if (file_name == "") { return; }

            objReader = new System.IO.StreamReader(file_name);

            string line = objReader.ReadLine();

            string[] input = line.Split(' ');

            string canvas_width_str = input[0].Substring(1);
            string canvas_height_str = input[1].Substring(1);
            string cell_size_str = input[2].Substring(1);

            int canvas_width = Convert.ToInt32(canvas_width_str);
            int canvas_height = Convert.ToInt32(canvas_height_str);
            int cell_size =  Convert.ToInt32(cell_size_str);

            createRoom(canvas_width, canvas_height, cell_size);

            for (int i = 0; i < canvas_width; i++)
            {
                line = objReader.ReadLine();

                input = line.Split(' ');

                for (int j = 0; j < canvas_width; j++)
                {

                    switch (input[j])
                    {
                        case("0"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.empty];
                            break;

                        case ("1"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.floor];
                            break;

                        case ("2"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.top];
                            break;

                        case ("3"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.right];
                            break;

                        case ("4"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.bottom];
                            break;

                        case ("5"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.left];
                            break;

                        case ("6"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.top_right_outter_corner];
                            break;

                        case ("7"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.bottom_right_outter_corner];
                            break;

                        case ("8"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.bottom_left_outter_corner];
                            break;

                        case ("9"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.top_left_outter_corner];
                            break;

                        case ("A"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                            break;

                        case ("B"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                            break;

                        case ("C"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                            break;

                        case ("D"):
                            cells[j + (i * canvas_width)].BackColor = cell_colors[(int)cell_type.top_left_inner_corner];
                            break;
                    }
                }
            }
            backup();
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

            if (file_name == "") { return; }

            objWriter = new System.IO.StreamWriter(file_name);

            string map_string = "";

            map_string += "W" + current_width + " H" + current_height + " C" + current_cell_size + "\r\n";

            int count = 0;
            int width = current_width;

            foreach (Control cell in cells)
            {
                if (count % width == 0 && count != 0) map_string += "\r\n";

                if (cell.BackColor == cell_colors[(int)cell_type.empty]) map_string += "0";
                else if (cell.BackColor == cell_colors[(int)cell_type.floor]) map_string += "1";
                else if (cell.BackColor == cell_colors[(int)cell_type.top]) map_string += "2";
                else if (cell.BackColor == cell_colors[(int)cell_type.right]) map_string += "3";
                else if (cell.BackColor == cell_colors[(int)cell_type.bottom]) map_string += "4";
                else if (cell.BackColor == cell_colors[(int)cell_type.left]) map_string += "5";
                else if (cell.BackColor == cell_colors[(int)cell_type.top_right_outter_corner]) map_string += "6";
                else if (cell.BackColor == cell_colors[(int)cell_type.bottom_right_outter_corner]) map_string += "7";
                else if (cell.BackColor == cell_colors[(int)cell_type.bottom_left_outter_corner]) map_string += "8";
                else if (cell.BackColor == cell_colors[(int)cell_type.top_left_outter_corner]) map_string += "9";
                else if (cell.BackColor == cell_colors[(int)cell_type.top_right_inner_corner]) map_string += "A";
                else if (cell.BackColor == cell_colors[(int)cell_type.bottom_right_inner_corner]) map_string += "B";
                else if (cell.BackColor == cell_colors[(int)cell_type.bottom_left_inner_corner]) map_string += "C";
                else if (cell.BackColor == cell_colors[(int)cell_type.top_left_inner_corner]) map_string += "D";

                map_string += ' ';
                count++;
            }

            objWriter.Write(map_string);
            objWriter.Close();
        }

        private void handleCellClick(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;

            if (rectanlgeMode_checked == true)
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
            backup();
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

        private void clearCanvas()
        {
            foreach (Control cell in cells)
            {
                cell.BackColor = Color.White;
            }
            backup();
        }

        private int getIndexAt(int x, int y)
        {
            return (y * current_width) + x;
        }

        private void printRectangle()
        {

            int a_x = pointOne % current_width;
            int a_y = (int)Math.Ceiling((double)(pointOne / current_width));

            int b_x = PointTwo % current_width;
            int b_y = (int)Math.Ceiling((double)(PointTwo / current_width));

            int width = Math.Abs(a_x - b_x);
            int height = Math.Abs(a_y - b_y);

            int origin = getOrigin();

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

        private void GenerateWalls()
        {

            int current_index = 0;
            foreach (PictureBox cell in cells)
            {
                if (cell.BackColor == Color.Blue)
                {
                    current_index = cells.IndexOf(cell);

                    int a_x = current_index % current_width;
                    int a_y = (int)Math.Ceiling((double)(current_index / current_width));

                    if (outOfBoundCells(a_x, a_y))
                    {

                        PictureBox cell_left = cells[getIndexAt(a_x - 1, a_y)];
                        PictureBox cell_right = cells[getIndexAt(a_x + 1, a_y)];
                        PictureBox cell_top = cells[getIndexAt(a_x, a_y - 1)];
                        PictureBox cell_bottom = cells[getIndexAt(a_x, a_y + 1)];

                        cell_type code = getTileCode(cell_left, cell_right, cell_top, cell_bottom);

                        switch (code)
                        {
                            // walls
                            case (cell_type.top):
                                if (cell_top.BackColor == cell_colors[(int)cell_type.left])
                                {
                                    cell_top.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                                }

                                else if (cell_top.BackColor == cell_colors[(int)cell_type.right])
                                {
                                    cell_top.BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                                }

                                else if (cell_top.BackColor == cell_colors[(int)cell_type.empty]) cell_top.BackColor = cell_colors[(int)cell_type.top];
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

                                else if (cell_bottom.BackColor == cell_colors[(int)cell_type.empty]) cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                                break;

                            case (cell_type.left):
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
                            case (cell_type.top_right_outter_corner):
                                cells[getIndexAt(a_x + 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_right_outter_corner];
                                cell_top.BackColor = cell_colors[(int)cell_type.top];
                                cell_right.BackColor = cell_colors[(int)cell_type.right];
                                break;

                            case (cell_type.bottom_right_outter_corner):
                                cells[getIndexAt(a_x + 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_right_outter_corner];
                                cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                                cell_right.BackColor = cell_colors[(int)cell_type.right];
                                break;

                            case (cell_type.bottom_left_outter_corner):
                                cells[getIndexAt(a_x - 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_left_outter_corner];
                                cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                                cell_left.BackColor = cell_colors[(int)cell_type.left];
                                break;

                            case (cell_type.top_left_outter_corner):
                                cells[getIndexAt(a_x - 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_left_outter_corner];
                                cell_top.BackColor = cell_colors[(int)cell_type.top];
                                cell_left.BackColor = cell_colors[(int)cell_type.left];
                                break;

                            case (cell_type.top_and_bottom):
                                if (cell_top.BackColor == cell_colors[(int)cell_type.left])
                                {
                                    cell_top.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                                }

                                else if (cell_top.BackColor == cell_colors[(int)cell_type.right])
                                {
                                    cell_top.BackColor = cell_colors[(int)cell_type.bottom_left_inner_corner];
                                }

                                else if (cell_top.BackColor == cell_colors[(int)cell_type.empty]) cell_top.BackColor = cell_colors[(int)cell_type.top];

                                if (cell_bottom.BackColor == cell_colors[(int)cell_type.left])
                                {
                                    cell_bottom.BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                                }

                                else if (cell_bottom.BackColor == cell_colors[(int)cell_type.right])
                                {
                                    cell_bottom.BackColor = cell_colors[(int)cell_type.top_left_inner_corner];
                                }

                                else if (cell_bottom.BackColor == cell_colors[(int)cell_type.empty]) cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];
                                break;

                            case (cell_type.left_and_right):
                                if (cell_left.BackColor == cell_colors[(int)cell_type.top])
                                {
                                    cell_right.BackColor = cell_colors[(int)cell_type.bottom_right_inner_corner];
                                }

                                else if (cell_left.BackColor == cell_colors[(int)cell_type.bottom])
                                {
                                    cell_left.BackColor = cell_colors[(int)cell_type.top_right_inner_corner];
                                }

                                else if (cell_left.BackColor == cell_colors[(int)cell_type.empty]) cell_left.BackColor = cell_colors[(int)cell_type.left];

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

                            case (cell_type.top_cul):
                                cell_top.BackColor = cell_colors[(int)cell_type.top];
                                cell_right.BackColor = cell_colors[(int)cell_type.right];
                                cell_left.BackColor = cell_colors[(int)cell_type.left];

                                cells[getIndexAt(a_x + 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_right_outter_corner];
                                cells[getIndexAt(a_x - 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_left_outter_corner];
                                break;

                            case (cell_type.right_cul):
                                cell_top.BackColor = cell_colors[(int)cell_type.top];
                                cell_right.BackColor = cell_colors[(int)cell_type.right];
                                cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];

                                cells[getIndexAt(a_x + 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_right_outter_corner];
                                cells[getIndexAt(a_x + 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_right_outter_corner];
                                break;

                            case (cell_type.bottom_cul):
                                cell_left.BackColor = cell_colors[(int)cell_type.left];
                                cell_right.BackColor = cell_colors[(int)cell_type.right];
                                cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];

                                cells[getIndexAt(a_x + 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_right_outter_corner];
                                cells[getIndexAt(a_x - 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_left_outter_corner];
                                break;

                            case (cell_type.left_cul):
                                cell_top.BackColor = cell_colors[(int)cell_type.top];
                                cell_left.BackColor = cell_colors[(int)cell_type.left];
                                cell_bottom.BackColor = cell_colors[(int)cell_type.bottom];

                                cells[getIndexAt(a_x - 1, a_y - 1)].BackColor = cell_colors[(int)cell_type.top_left_outter_corner];
                                cells[getIndexAt(a_x - 1, a_y + 1)].BackColor = cell_colors[(int)cell_type.bottom_left_outter_corner];
                                break;
                        }
                    }
                }
            }
            secondPass();
            backup();
        }

        private void secondPass()
        {
            int current_index = 0;
            foreach (PictureBox cell in cells)
            {
                if (cell.BackColor != cell_colors[(int)cell_type.floor] && cell.BackColor != cell_colors[(int)cell_type.empty])
                {
                    current_index = cells.IndexOf(cell);

                    int a_x = current_index % current_width;
                    int a_y = (int)Math.Ceiling((double)(current_index / current_width));

                    if(outOfBoundCells(a_x, a_y))
                    {

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

            // top and bottom
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.top_and_bottom;
            }

            // left and right
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.left_and_right;
            }

            // top_cul
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor == Color.Blue)
            {
                return cell_type.top_cul;
            }

            // right_cul
            if (cell_left.BackColor == Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.right_cul;
            }

            // bottom_cul
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor != Color.Blue &&
                cell_top.BackColor == Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.bottom_cul;
            }

            // left_cul
            if (cell_left.BackColor != Color.Blue &&
                cell_right.BackColor == Color.Blue &&
                cell_top.BackColor != Color.Blue &&
                cell_bottom.BackColor != Color.Blue)
            {
                return cell_type.left_cul;
            }

            return cell_type.empty;
        }

        public void removeCanvas()
        {
            foreach (PictureBox cell in cells)
            {
                this.Controls.Remove(cell);
                cell.Dispose();
            }

            cells.Clear();
            clearUndo();

        }

        private void clearWalls()
        {
            foreach (PictureBox cell in cells)
            {
                if(cell.BackColor != cell_colors[(int)cell_type.empty] && cell.BackColor != cell_colors[(int)cell_type.floor])
                {
                    cell.BackColor = cell_colors[(int)cell_type.empty];
                }
            }
            backup();
        }

        private bool outOfBoundCells(int a_x, int a_y)
        {
            return (a_x - 1 >= 0 && a_x + 1 != 0 && a_y - 1 >= 0 && a_y + 1 < current_height);
        }

        public void setCurrentColor(cell_type type)
        {
            selected_color = cell_colors[(int)type];
            current_selection_box.BackColor = cell_colors[(int)type];
        }

        private int getOrigin()
        {

            int a_x = pointOne % current_width;
            int a_y = (int)Math.Ceiling((double)(pointOne / current_width));

            int b_x = PointTwo % current_width;
            int b_y = (int)Math.Ceiling((double)(PointTwo / current_width));

            int origin_x = a_x >= b_x ? b_x : a_x;
            int origin_y = a_y >= b_y ? b_y : a_y;

            return getIndexAt(origin_x, origin_y);
        }

        private void backup()
        {
            /*if (undo_index >= undo_max)
            {
                undo_stack.RemoveAt(0);
                undo_stack[undo_index] = new List<PictureBox>(cells.Count);

                foreach(PictureBox cell in cells)
                {

                    undo_stack[undo_index].Add(cell);
                }
            }
            else
            {  
                undo_stack.Add(new List<PictureBox>(cells));
                undo_index++;
                De*/bug.WriteLine("backed up data:" + undo_index);
            }
        }

        private void undo()
        {
            /*if (undo_index >= 1)
            {
                Debug.WriteLine(undo_stack.Count);
                Debug.WriteLine(undo_index);
                //cells = undo_stack[undo_index];
                for (int i = 0; i < cells.Count; i++)
                {
                    Debug.WriteLine("replaced " + cells[i].BackColor + " to " + undo_stack[undo_index - 1][i].BackColor);
                    cells[i].BackColor = undo_stack[ undo_index - 1][i].BackColor;
                }
                    undo_index--;
            }*/
        }

        private void redo()
        {
            /*if (undo_index < undo_max)
            {
                undo_index++;
                cells = undo_stack[undo_index];
            }*/
        }

        private void clearUndo()
        {

            //undo_stack.Clear();
        }

        /*
         * Menu Items
         * 
         * */

        private void createNewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRoomForm create_form = new NewRoomForm(this);
            create_form.Show();
        }

        private void exportRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void generateWallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateWalls();
        }

        private void clearRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearCanvas();
        }

        private void rectangleDrawModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectanlgeMode_checked = rectanlgeMode_checked ? false : true;
            rectangleDrawModeToolStripMenuItem.Checked = rectanlgeMode_checked;
            rectangleModeStatus.Text = rectanlgeMode_checked ? "Rectangle Mode: ON" : "Rectangle Mode: OFF";
        }

        private void floorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.floor);
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.empty);
        }

        private void topToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.top);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.right);
        }

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.bottom);
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.left);
        }

        private void topRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.top_right_outter_corner);
        }

        private void bottomRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.bottom_right_outter_corner);
        }

        private void bottomLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.bottom_left_outter_corner);
        }

        private void topLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.top_left_outter_corner);
        }

        private void topRightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.top_right_inner_corner);
        }

        private void bottomRightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.bottom_right_inner_corner);
        }

        private void bottomLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.bottom_left_inner_corner);
        }

        private void topLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCurrentColor(cell_type.top_left_inner_corner);
        }

        private void openRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadMap();
        }

        private void clearWallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearWalls();
        }

        private void wallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorPicker color_picker = new ColorPicker(this);
            color_picker.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo();
        }
    }
}
