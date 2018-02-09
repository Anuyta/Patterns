using ServicesLib.Interfaces;
using System.IO;
using System.Windows.Forms;

namespace ServicesLib
{
    internal class FileService : IFileService
    {
        private static readonly FileService instance = new FileService();
        private string fileName;

        static FileService()
        {
        }

        private FileService()
        {
        }

        public static FileService GetInstance()
        {
            return instance;
        }

        public string OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                fileName = ofd.FileName;
            }
            return fileName;
        }

        public void PersistFile()
        {
            string destPath = GetPathDestination();
            File.Copy(fileName, Path.Combine(destPath, Path.GetFileName(fileName)));
        }

        public void DeleteFile()
        {
            File.Delete(fileName);
        }

        public void MoveFile()
        {
            string destPath = GetPathDestination();
            File.Move(fileName, Path.Combine(destPath, Path.GetFileName(fileName)));
        }

        private static string GetPathDestination()
        {
            string destPath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                destPath = fbd.SelectedPath;
            }

            return destPath;
        }
    }
}
