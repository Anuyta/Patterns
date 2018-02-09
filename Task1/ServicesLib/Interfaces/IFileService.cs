using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Interfaces
{
    public interface IFileService
    {
        string OpenFile();

        void PersistFile();

        void DeleteFile();

        void MoveFile();
    }
}
