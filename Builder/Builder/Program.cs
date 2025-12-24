using MazeLibrary;
using MazeLibrary.Doors;
using System;
namespace Builder.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new BuilderMazeGame();
                var standardBuilder = new StandardMazeBuilder();
                var maze = client.CreateMaze(standardBuilder);

                var start = maze.RoomNo(1);
                start.Enter();

                Door doorToGo = null;
                Direction doorDir = Direction.North;
                foreach (Direction d in new[] { Direction.North, Direction.South, Direction.East, Direction.West })
                {
                    var side = start.GetSide(d);
                    var door = side as Door;
                    if (door != null)
                    {
                        doorToGo = door;
                        doorDir = d;
                        break;
                    }
                }


                Console.WriteLine();
                Console.WriteLine("Создалась фабрика: CountingMazeBuilder");
                var counting = new CountingMazeBuilder();
                client.CreateMaze(counting);
                counting.GetCounts(out int rooms, out int doors);
                Console.WriteLine($"(подсчёт) комнат = {rooms}, дверей = {doors}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}