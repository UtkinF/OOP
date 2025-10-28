using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class Room: MapSite
    {
        public int RoomNumber { get; }
        MapSite[] sides = new MapSite[4]; 

        public Room(int roomNo)
        {
            RoomNumber = roomNo;
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction directon, MapSite site)
        {
            sides[(int)directon] = site;
        }

        public override void Enter()
        {
           Console.WriteLine($"Вы вошли в #{RoomNumber} комнату");
        }
    }
}
