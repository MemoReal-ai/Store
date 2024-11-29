
using System.Collections.Generic;
using UnityEngine;

public class DataPeresistense : MonoBehaviour
{
    private const string ItemKeyPrefix = "Item_";     
    private const string ResourceKeyPrefix = "Resource_"; 

    public void SaveGame(ResourcesManager resourcesManager, ItemManager itemManager)
    {
     
        foreach (var item in itemManager.items)
        {
            PlayerPrefs.SetInt(ItemKeyPrefix + item.id, item.isAvailable ? 1 : 0); 
        }

    
        foreach (var resource in resourcesManager.resourseItems)
        {
            PlayerPrefs.SetFloat(ResourceKeyPrefix + resource.Name, resource.amount); 
        }

        PlayerPrefs.Save(); 
    }

    public void LoadGame(ResourcesManager resourcesManager, ItemManager itemManager)
    {
       
        foreach (var item in itemManager.items)
        {
            int isAvailable = PlayerPrefs.GetInt(ItemKeyPrefix + item.id, 0); 
            item.isAvailable = isAvailable == 1; 
        }

        
        foreach (var resource in resourcesManager.resourseItems)
        {
            float amount = PlayerPrefs.GetFloat(ResourceKeyPrefix + resource.Name, 0); 
            resource.amount = amount; 
        }
    }

}

[System.Serializable]
public class GameData
{
   public List<ItemData> itemData; 
   public List<ResourcesData> data;

    [System.Serializable]
    public class ResourcesData
    {
        public float amount;
        public string name;
    }
    [System.Serializable]
    public class ItemData
    {
        public int id;
        public bool isAvaible;
    }
}