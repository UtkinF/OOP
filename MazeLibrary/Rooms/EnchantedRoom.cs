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

        public EnchantedRoom(int number) : base(number)
        {
            _spell = new Spell("Levitation");
        }

        public EnchantedRoom(int roomNumber, Spell spell):base(roomNumber)
        {
            _spell = spell;
            RoomNumber = roomNumber;
        }

        public void Initialize(Spell spell)
        {
            _spell = spell;
        }

        public EnchantedRoom(EnchantedRoom otherRoom):base(otherRoom)
        {
            _spell = otherRoom._spell;
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в магическую комнату #{RoomNumber} (используя заклинание: {_spell.Incantation})");
        }

        public override Room Clone()
        {
            Console.WriteLine("Вы клонировали магическую комнату");
            return new EnchantedRoom(this);
        }
    }
}
