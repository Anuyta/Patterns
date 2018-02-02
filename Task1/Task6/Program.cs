using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var chat = new ChatRoom();
            var part1 = new Participant(chat, "Иван");
            var part2 = new Participant(chat, "Леша");
            var part3 = new Participant(chat, "Юлия");
            
            part1.SendMessage("всем приветик!");
            part2.SendMessage("Hello");
            part3.SendMessage("И тебе привет");

            Console.WriteLine();

            part1.CreateDialog(part2);
            part1.SendPersonalMessage("проверка связи", part2);

            Console.ReadLine();
        }
    }
}
