using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Rooms;


namespace Builder.Builder
{
    public static class CreateDirection
    {
        public static Direction CommonWall(Room r1, Room r2)
        {
            if (r2.RoomNumber == r1.RoomNumber + 1) return Direction.East;
            if (r2.RoomNumber == r1.RoomNumber - 1) return Direction.West;
            if (r2.RoomNumber > r1.RoomNumber) return Direction.South;
            return Direction.North;
        }

        public static Direction Opposite(Direction d)
        {
            switch (d)
            {
                case Direction.North: return Direction.South;
                case Direction.East: return Direction.West;
                case Direction.South: return Direction.North;
                case Direction.West: return Direction.East;
                default: throw new ArgumentException("Ошибочное значение");
            }
        }
    }
}
