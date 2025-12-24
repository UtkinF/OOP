using MazeFactoryMethod;
using MazeFactoryMethod.MazeFactoryMethod;

namespace Program
{
    class ProgramFactoryMethod
    {
        static void Main(string[] args)
        {
            try
            {
                MazeCreator justmaze = new MazeCreator();
                justmaze.CreateMaze();

                EnchantedMazeCreator enchactedmaze = new EnchantedMazeCreator();
                enchactedmaze.CreateMaze();

                BombedMazeCreator bombedmaze = new BombedMazeCreator();
                bombedmaze.CreateMaze();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
