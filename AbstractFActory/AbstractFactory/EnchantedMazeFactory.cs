using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary;

namespace AbstractFActory.AbstractFactory
{
    public class EnchantedMazeFactory:MazeFactory
    {
        public EnchantedMazeFactory()
        {
            Console.WriteLine("Создана EnchantedMazeFactory");
        }

        public Spell CastSpel => new Spell("Ekspektro Patronos");

        public override Room MakeRoom(int n) =>
      (n > 0) ? new EnchantedRoom(n, CastSpel) : throw new ArgumentException("Номер комнаты должен быть натуральным числом");

        public override Door MakeDoor(Room r1, Room r2) => new DoorNeedingSpell(r1, r2);

    }
}
