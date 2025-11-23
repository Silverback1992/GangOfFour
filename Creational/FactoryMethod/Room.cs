namespace FactoryMethod;

public class Room : MapSite
{
    private readonly MapSite[] _sides = new MapSite[4];

    public int RoomNumber { get; set; }

    public Room(int roomNumber)
    {
        RoomNumber = roomNumber;
    }

    public MapSite GetSide(Direction direction) => _sides[(int)direction];
    public void SetSide(Direction direction, MapSite mapSite) => _sides[(int)direction] = mapSite;
}
