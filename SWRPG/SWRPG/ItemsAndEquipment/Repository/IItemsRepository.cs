using System.Collections.Generic;
using ItemsAndEquipment.ItemTypes;


namespace ItemsAndEquipment.Repository
{
    public interface IItemsRepository
    {
        IEnumerable<Item> GetItems();

        Item GetItem(string itemName);

        void AddItem(Item item);

        void UpdateItem(Item itemUpdate, string itemToUpdate);

        void DeleteItem(string itemName);

        void UpdateItems(IEnumerable<Item> updatedItems);
    }
}
