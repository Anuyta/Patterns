using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class MainForm : Form
    {
        CharacterFactory factory = new CharacterFactory();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            factory.GetCharacter('A', new Bitmap(@"..\..\Images\A.png"));
            factory.GetCharacter('B', new Bitmap(@"..\..\Images\B.png"));
            factory.GetCharacter('C', new Bitmap(@"..\..\Images\C.png"));
            factory.GetCharacter('D', new Bitmap(@"..\..\Images\D.png"));
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            Graphics grf = pbImage.CreateGraphics();
            grf.Clear(Color.White);

            factory.GetCharacter(btn.Text[0]).Drow(grf, 0, 0);
        }
    }
}
