using AbstractFActory.AbstractFactory;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;

public class SimpleMazeFactory : MazeFactory
{
    public SimpleMazeFactory()
    {
        Console.WriteLine("Создана SimpleMazeFactory");
    }
    public override Wall MakeWall()
    {
        return new Wall();
    }
    public override Room MakeRoom(int n)
    {
        return new Room(n);
    }
}