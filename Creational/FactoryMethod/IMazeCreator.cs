namespace FactoryMethod;
public interface IMazeCreator
{
    Maze CreateMaze() => new();
    Room CreateRoom(int roomNumber) => new(roomNumber);
    Wall CreateWall() => new();
    Door CreateDoor(Room r1, Room r2) => new(r1, r2);
}
