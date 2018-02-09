using ServicesLib;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        private ServiceFactory factory;
        private IAudioService audio;
        private AudioInfo audioInfo;
        private IFileService fileService;

        public MainForm()
        {
            InitializeComponent();

            factory = new ServiceFactory();
            audioInfo = new AudioInfo();
            fileService = factory.GetFileService();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn == btnOpenFile)
            {
                OpenFile();
            }
            else if(btn == btnPlay)
            {
                audio.Play();
            }
            else if(btn == btnStop)
            {
                audio.Stop();
            }
            else if(btn == btnDelete)
            {
                DeleteFile();
            }
            else if(btn == btnMove)
            {
                MoveFile();
            }
            else if(btn == btnSaveFile)
            {
                SaveFile();
            }
        }

        private void SaveFile()
        {
            fileService.PersistFile();
            MessageBox.Show("файл сохранен");
            HideControls();
        }

        private void MoveFile()
        {
            fileService.MoveFile();
            HideControls();
            audio.Stop();
            MessageBox.Show("файл перемещен");
        }
        
        private void DeleteFile()
        {
            
            fileService.DeleteFile();
            HideControls();
            audio.Stop();
            MessageBox.Show("файл удален");
        }

        private void OpenFile()
        {
            try
            {
                IFileService file = factory.GetFileService();
                audio = factory.GetAudioService();
                audioInfo = audio.GetInfoAboutFile(file.OpenFile());
                lbName.Text = audioInfo.nameFile;
                lbPath.Text = audioInfo.pathFile;
                lbSize.Text = audioInfo.Size.ToString() + " МБ";
            }
            catch (Exception ex)
            {
                IMessageService msg = factory.GetMessageService();
                msg.ShowMessageBox(ex);
            }
            btnPlay.Enabled = true;
            btnStop.Enabled = true;
            btnSaveFile.Enabled = true;
            btnDelete.Enabled = true;
            btnMove.Enabled = true;
        }
        
        private void HideControls()
        {
            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            btnSaveFile.Enabled = false;
            btnDelete.Enabled = false;
            btnMove.Enabled = false;
            lbName.Text = "";
            lbPath.Text = "";
            lbSize.Text = "";
        }
    }
}
