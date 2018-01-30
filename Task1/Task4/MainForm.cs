using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class MainForm : Form
    {
        private ImagePool pool;

        public MainForm()
        {
            InitializeComponent();
            pool = new ImagePool(4);
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn == btnOpenImage)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All files (*.*)|*.*|png (*.png)|*.png|jpg (*.jpg)|*.jpg";
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    btnGetNegative.Enabled = true;
                    btnSaveImage.Enabled = true;
                    btnTurnLeft.Enabled = true;
                    btnTurnRight.Enabled = true;
                    btnShowOriginal.Enabled = true;       
                    pool.CreateObjects(ofd.FileName);
                    pbImage.Image = pool.GetImages[0];
                }
            }
            else if (btn == btnGetNegative)
            {
                pbImage.Image = pool.GetImages[1];
            }
            else if (btn == btnTurnRight)
            {
                pbImage.Image = pool.GetImages[2];
            }
            else if (btn == btnTurnLeft)
            {
                pbImage.Image = pool.GetImages[3];
            }
            else if (btn == btnShowOriginal)
            {
                pbImage.Image = pool.GetImages[0];
            }
            else if(btn == btnSaveImage)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "png (*.png)|*.png|jpg (*.jpg)|*.jpg";
                sfd.FileName = "Image";
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    pbImage.Image.Save(sfd.FileName);
                }
            }
        }
    }
}
