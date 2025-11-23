namespace FactoryMethod;

public class MazeGame
{
    private readonly IMazeCreator _mazeCreator;

    public MazeGame(IMazeCreator mazeCreator)
    {
        _mazeCreator = mazeCreator;
    }

    public Maze CreateMaze()
    {
        var maze = _mazeCreator.CreateMaze();
        var r1 = _mazeCreator.CreateRoom(1);
        var r2 = _mazeCreator.CreateRoom(2);
        var door = _mazeCreator.CreateDoor(r1, r2);

        maze.AddRoom(r1);
        maze.AddRoom(r2);

        r1.SetSide(Direction.North, _mazeCreator.CreateWall());
        r1.SetSide(Direction.East, door);
        r1.SetSide(Direction.South, _mazeCreator.CreateWall());
        r1.SetSide(Direction.West, _mazeCreator.CreateWall());

        r2.SetSide(Direction.North, _mazeCreator.CreateWall());
        r2.SetSide(Direction.East, _mazeCreator.CreateWall());
        r2.SetSide(Direction.South, _mazeCreator.CreateWall());
        r2.SetSide(Direction.West, door);

        return maze;
    }
}
