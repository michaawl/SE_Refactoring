namespace GildedRoseKata;

public class AgedBrieUpdater : IItemUpdater
{
    public bool CanHandle(Item item) => item.Name == "Aged Brie";

    public void Update(Item item)
    {
        item.SellIn--;
        if (item.Quality < QualityBounds.Max) item.Quality++;
        if (item.SellIn < 0 && item.Quality < QualityBounds.Max) item.Quality++;
    }
}