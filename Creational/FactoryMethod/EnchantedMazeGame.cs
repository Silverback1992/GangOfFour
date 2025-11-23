namespace FactoryMethod;
public class EnchantedMazeGame : IMazeCreator
{
    protected Spell CastSpell() => new();

    public Room CreateRoom(int roomNumber)
    {
        return new EnchantedRoom(roomNumber, CastSpell());
    }

    public Door CreateDoor(Room r1, Room r2)
    {
        return new DoorNeedingSpell(r1, r2);
    }
}
