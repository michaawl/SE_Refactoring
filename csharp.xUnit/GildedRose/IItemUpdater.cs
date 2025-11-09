namespace GildedRoseKata;

public interface IItemUpdater
{
    bool CanHandle(Item item);
    void Update(Item item);
}
