using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;

namespace AbstractFActory.AbstractFactory
{
    public class MazeFactory
    {
        public MazeFactory() 
        {
        }
        public MazeFactory(string n)
        {
            Console.WriteLine("Создание всех фабрик по-очереди\n");
        }
        public virtual Maze MakeMaze() => new Maze();
        public virtual Wall MakeWall() => new Wall();
        public virtual Room MakeRoom(int n) => new Room(n);
        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);
    }
}
