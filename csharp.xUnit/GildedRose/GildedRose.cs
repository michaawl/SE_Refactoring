using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
    private readonly List<IItemUpdater> _updaters;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
        _updaters = new List<IItemUpdater>
        {
            new AgedBrieUpdater(),
            new BackstagePassUpdater(),
            new SulfurasUpdater(),
            new DefaultItemUpdater()
        };
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            var updater = _updaters.First(u => u.CanHandle(item));
            updater.Update(item);
        }
    }
}