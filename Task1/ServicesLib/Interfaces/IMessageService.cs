using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Interfaces
{
    public interface IMessageService
    {
        void ShowMessageBox(Exception exp);
    }
}
