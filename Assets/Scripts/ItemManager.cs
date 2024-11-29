using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private List<ItemObject> items = new List<ItemObject>();

    private void Start()
    {
       
    }

    private void Update()
    {
        foreach (var item in items) 
        {
            item.TimeToEqiep();
        }
    }
    public string DisplayItems(int targetItem)
    {
        foreach (ItemObject item in items)
        {
            if (item.id+1 == targetItem)
            {
                return item.name;
            }
        }
        return "NotFound";
    }
    public (float,float) DisplayCost(int targetItem)
    {
        foreach (ItemObject item in items)
        {
            if (item.id + 1 == targetItem)
            {
                return (item.cost,item.altCost) ;
            }
        }



        return (0f,0f);
    }

    public bool IsVisible(int targetItem)
    {
        foreach (ItemObject item in items)
        {
            if (item.id + 1 == targetItem)
            {
                return item.isAvailable;
            }
        }

        return false;
    }
    public ItemObject GetId(int id)
    {
        foreach (var item in items)
        {
            if (item.id ==id)

                return item;
        }
        return null;
    }
}

