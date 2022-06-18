using System;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armoer,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);

        static Item FindItem(ItemSelector selector)
        {
            foreach(Item item in _items)
            {
                if (selector(item))
                    return item;
            }

            return null;
        }

        //static Item FindRareItem()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.Rarity == Rarity.Rare)
        //            return item;
        //    }

        //    return null;
        //}

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armoer, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });
            // Lambda : 일회용 함수를 만드는데 사용하는 문법.

            // 무명함수
            Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            // 람다
            Item item2 = FindItem((Item item2) => { return item.ItemType == ItemType.Weapon; });
        }
    }
}