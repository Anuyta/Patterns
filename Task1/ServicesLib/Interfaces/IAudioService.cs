using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Interfaces
{
    public interface IAudioService
    {
        void Play();

        void Stop();

        AudioInfo GetInfoAboutFile(string fileName);
    }
}
