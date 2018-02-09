using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Participant
    {
        private readonly ChatRoom chatRoom;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Participant(ChatRoom chatRoom, string name)
        {
            this.chatRoom = chatRoom;
            this.name = name;
            this.chatRoom.AddToChatRoom(this);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Пользователь {0}: {1}", Name, message);
            chatRoom.SendMessageToMembers(message, Name);
        }

        public void SendPersonalMessage(string message, Participant part)
        {
            ReceiveMessage(message, part.Name);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            if(senderName != Name)
            {
                Console.WriteLine("Сообщение для {0} от {1}: {2}", name, senderName, message);
            }
        }

        public void CreateDialog(Participant part)
        {
            var chat = new ChatRoom();
            chat.AddToChatRoom(part);
            Console.WriteLine("Открыт личный диалог");
        }
    }
}
