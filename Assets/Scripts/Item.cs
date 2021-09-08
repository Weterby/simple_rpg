using System.Collections;
using System.Collections.Generic;

public class Item
{
    public List<BaseStat> ItemStats {get; set;}
    public string ItemName { get; set; }

    public Item(List<BaseStat> itemStats, string itemName)
    {
        this.ItemStats = itemStats;
        this.ItemName = itemName;
    }
}
