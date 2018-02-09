using ServicesLib.Interfaces;

namespace ServicesLib
{
    public class ServiceFactory
    {
        public IFileService GetFileService()
        {
            return FileService.GetInstance();
        }

        public IAudioService GetAudioService()
        {
            return AudioService.GetInstance();
        }

        public IMessageService GetMessageService()
        {
            return MessageBoxService.GetInstance();
        }
    }
}
