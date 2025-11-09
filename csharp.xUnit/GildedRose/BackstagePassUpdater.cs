namespace GildedRoseKata;

public class BackstagePassUpdater : IItemUpdater
{
    public bool CanHandle(Item item) =>
        item.Name == "Backstage passes to a TAFKAL80ETC concert";

    public void Update(Item item)
    {
        item.SellIn--;
        if (item.SellIn < 0) { item.Quality = 0; return; }

        if (item.Quality < QualityBounds.Max) item.Quality++;
        if (item.SellIn < 10 && item.Quality < QualityBounds.Max) item.Quality++;
        if (item.SellIn < 5 && item.Quality < QualityBounds.Max) item.Quality++;
    }
}