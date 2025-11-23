namespace FactoryMethod;
public class EnchantedRoom : Room
{
    private readonly Spell _spell;

    public EnchantedRoom(int roomNumber, Spell spell) : base(roomNumber)
    {
        _spell = spell;
    }
}
