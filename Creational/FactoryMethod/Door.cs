namespace FactoryMethod;

public class Door : MapSite
{
    private readonly Room _room1;
    private readonly Room _room2;
    private readonly bool _isOpen;

    public Door(Room room1, Room room2)
    {
        _room1 = room1;
        _room2 = room2;
    }

    public Room OtherSideFrom(Room room)
    {
        if (room == _room1)
        {
            return _room1;
        }

        if (room == _room2)
        {
            return _room2;
        }

        throw new ArgumentException("Room is not connected to this door");
    }
}
