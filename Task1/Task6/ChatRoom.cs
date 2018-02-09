using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ChatRoom
    {
        private readonly ISet<Participant> participants = 
                    new HashSet<Participant>();

        public void AddToChatRoom(Participant participant)
        {
            participants.Add(participant);
            WelcomeToChat(participant);
        }

        public void ExitFromChatRoom(Participant participant)
        {
            participants.Remove(participant);
        }

        public void SendMessageToMembers(string message, string senderName)
        {
            foreach (var part in participants)
            {
                part.ReceiveMessage(message, senderName);
            }
            SaveChatMessage(message, senderName);
        }

        private void WelcomeToChat(Participant participant)
        {
            Console.WriteLine("Пользователь {0} присоединился к чату!", participant.Name);
        }

        private void SaveChatMessage(string message, string senderName)
        {
            using (StreamWriter sw = new StreamWriter("MessageLog.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(string.Format("{0} Пользователь {1}: {2}", DateTime.Now, senderName, message));
                foreach (var part in participants)
                {
                    sw.WriteLine(string.Format("{0} Сообщение для {1} от {2}: {3}", DateTime.Now, part.Name, senderName, message));
                }
            }
        }
    }
}
