namespace FactoryMethod;
public class BombedMazeCreator : IMazeCreator
{
    public Wall CreateWall()
    {
        return new BombedWall();
    }

    public Room CreateRoom(int roomNumber)
    {
        return new RoomWithABomb(roomNumber);
    }
}
