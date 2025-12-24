using MazeLibrary;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFactoryMethod.MazeFactoryMethod
{
    public class EnchantedMazeCreator : MazeCreator
    {
        public Spell CastSpel => new Spell("Ekspektro Patronos");
        protected override Maze MakeMaze()
        {
            Console.WriteLine("Вы создали магический лабиринт");
            return new Maze();
        }

        protected override Room MakeRoom(int number)
        {
            Console.WriteLine($"Вы создали магическую комнату №{number}");
            return new EnchantedRoom(number, CastSpel);
        }

        protected override Door MakeDoor(Room room1, Room room2)
        {
            Console.WriteLine($"Вы создали магическую дверь между комнатами №{room1.RoomNumber} и №{room2.RoomNumber}");
            return new DoorNeedingSpell(room1, room2);
        }
    }
}