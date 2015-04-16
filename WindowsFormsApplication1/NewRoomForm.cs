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
    public partial class NewRoomForm : Form
    {
        private Form1 _mainWindow;

        public NewRoomForm(Form1 mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void NewRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            int x_count = (int)xValuePicker.Value;
            int y_count = (int)yValuePicker.Value;
            int size = (int)cellSizePicker.Value;

            _mainWindow.createRoom(x_count, y_count, size);
            this.Close();
        }
    }
}
