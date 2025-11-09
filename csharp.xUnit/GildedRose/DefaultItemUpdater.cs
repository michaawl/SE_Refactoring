namespace GildedRoseKata;

public class DefaultItemUpdater : IItemUpdater
{
    public bool CanHandle(Item item) => true;

    public void Update(Item item)
    {
        item.SellIn--;
        if (item.Quality > QualityBounds.Min) item.Quality--;
        if (item.SellIn < 0 && item.Quality > QualityBounds.Min) item.Quality--;
        if (item.Quality < QualityBounds.Min) item.Quality = QualityBounds.Min;
    }
}
