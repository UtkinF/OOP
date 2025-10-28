using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom: Room
    {
        private Spell _spell;
        public int RoomNumber { get; }
        public EnchantedRoom(int roomNumber, Spell spell):base(roomNumber)
        {
            _spell = spell;
            RoomNumber = roomNumber;
        }
        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в магическую комнату #{RoomNumber} (используя заклинание: {_spell.Incantation})");
        }
    }
}
