using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ColorPicker : Form
    {
        private Form1 _mainWindow;
        public ColorPicker(Form1 mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void topLeftOuterTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.top_left_outter_corner);
        }

        private void topRightOuterTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.top_right_outter_corner);
        }

        private void bottomRightOuterTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.bottom_right_outter_corner);
        }

        private void bottomLeftOuterTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.bottom_left_outter_corner);
        }

        private void topTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.top);
        }

        private void rightTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.right);
        }

        private void bottomTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.bottom);
        }

        private void leftTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.left);
        }

        private void topRightInnerTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.top_right_inner_corner);
        }

        private void bottomRightInnerTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.bottom_right_inner_corner);
        }

        private void bottomLeftInnerTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.bottom_left_inner_corner);
        }

        private void topLeftInnerTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.top_left_inner_corner);
        }

        private void emptyTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.empty);
        }

        private void floorTilePicker_Click(object sender, EventArgs e)
        {
            _mainWindow.setCurrentColor(Form1.cell_type.floor);
        }
    }
}
