using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        ElementFactory factory = new ElementFactory();
        Color curColor = Color.Black;
        Point point1;
        Point point2;
        Graphics gr;

        public MainForm()
        {
            InitializeComponent();
            gr = pbMain.CreateGraphics();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnClear)
            {
                pbMain.Refresh();
                return;
            }

            if (DialogResult.OK == colorDlg.ShowDialog())
            {
                curColor = colorDlg.Color;
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            point1 = e.Location;
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            point2 = e.Location;
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                point2 = point1;
                point1 = e.Location;
                factory.GetCharacter(curColor).Drow(gr, point1, point2);
            }
        }
    }
}
