using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager: MonoBehaviour
{
    public List<ResourcesItem> resourseItems = new List<ResourcesItem>();
   
    private ItemManager itemManager;
    private void Start()
    {
        TEST();  

    }

    private void TEST()
    {
        if (resourseItems.Count == 0)
        {
            resourseItems.Add(new ResourcesItem(ResourcesType.Gold, 100));
            resourseItems.Add(new ResourcesItem(ResourcesType.Silver, 50));
           
        }
    }
    public void AddResources(ResourcesType nameResources,float amount)
    {
        foreach (var resource in resourseItems)
        {
            if (resource.Name == nameResources)
            {
                resource.amount += amount;
                return;
            }        
        }
        resourseItems.Add(new ResourcesItem(nameResources, amount));
    }

    public bool Purches(ItemObject item, ResourcesType currencyType)
    {
        float cost = (currencyType == ResourcesType.Gold) ? item.cost : item.altCost; 

        if (cost > 0 && OpportunityTobuy(currencyType, cost))
        {
            ReducedResources(currencyType, cost);
            item.ToogleActive();
            return true; 
        }

        return false; 
    }
    //public bool Purches(ItemObject item)
    //{
    //    bool purchased=false;

    //    if(item.cost>0&&OpportunityTobuy(ResourcesType.Gold, item.cost))
    //    {
    //        ReducedResources(ResourcesType.Gold, item.cost);
    //        item.ToogleActive();
    //        purchased=true;
    //    }

    //    if(!purchased&&item.cost > 0 && OpportunityTobuy(ResourcesType.Silver, item.cost))
    //    {
    //        ReducedResources(ResourcesType.Silver, item.cost);
    //        item.ToogleActive();
    //        purchased = true;
    //    }

    //    if(purchased)
    //        return purchased;

    //        return false;
    //}

    private void ReducedResources(ResourcesType type, float cost)
    {
        foreach(var resource in resourseItems)
            if(resource.Name == type)
                resource.amount-=cost;
                    return;
    }

    public bool OpportunityTobuy(ResourcesType type,float cost)
    {
        foreach (var resource in resourseItems)
        {
            if (resource.Name == type && resource.amount >= cost)
                return true;
        }


        return false;
    }
  
    
    public float GetInfoResources(ResourcesType resourcesType)
    {
        foreach (var item in resourseItems)
        {if (item.Name == resourcesType)
                
           return item.amount;
        }
        return 0f;
    }

   

}
