using ServicesLib.Interfaces;
using System;
using System.Windows.Forms;

namespace ServicesLib
{
    internal class MessageBoxService :IMessageService
    {
        private static readonly MessageBoxService instance = new MessageBoxService();

        static MessageBoxService()
        {
        }

        private MessageBoxService()
        {
        }

        public static MessageBoxService GetInstance()
        {
            return instance;
        }

        public void ShowMessageBox(Exception exp)
        {
            MessageBox.Show(exp.Message, "Возникло исключение!");
        }
    }
}
