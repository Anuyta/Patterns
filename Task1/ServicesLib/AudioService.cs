using ServicesLib.Interfaces;
using System;
using System.IO;
using WMPLib;

namespace ServicesLib
{
    internal class AudioService : IAudioService
    {
        private static readonly AudioService instance = new AudioService();
        private static readonly WindowsMediaPlayer player = new WindowsMediaPlayer();
        private AudioInfo info = new AudioInfo();

        static AudioService()
        {
        }

        private AudioService()
        {
        }

        public static AudioService GetInstance()
        {
            return instance;
        }

        public void Play()
        {
            player.settings.volume = 100;
            player.URL = Path.Combine(info.pathFile, info.nameFile);
            player.controls.play();
        }

        public void Stop()
        {
            player.controls.stop();
        }


        public AudioInfo GetInfoAboutFile(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            info.nameFile = fileInfo.Name;
            info.pathFile = fileInfo.DirectoryName;
            info.Size = Math.Round(((double)fileInfo.Length / 1000000), 2);
            return info;
        }
    }
}
