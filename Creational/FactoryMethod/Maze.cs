namespace FactoryMethod;

public class Maze
{
    private readonly List<Room> _rooms = [];

    public void AddRoom(Room room) => _rooms.Add(room);

    public Room GetRoom(int roomNumber)
    {
        var room = _rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);

        return room ?? throw new ArgumentException("No room found with this number.");
    }
}
