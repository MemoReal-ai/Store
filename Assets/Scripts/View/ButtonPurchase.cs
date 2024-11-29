using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPurchase : MonoBehaviour
{
    
    [SerializeField] private Button buttonGold;
    [SerializeField] private  ItemManager itemManager;
    [SerializeField] private ResourcesManager resourcesManager;
    [SerializeField] private Button buttonSilver;

    public int id;
    void Start()
    {
        buttonGold.onClick.AddListener(()=>Buy(ResourcesType.Gold));
        buttonSilver.onClick.AddListener(()=>Buy(ResourcesType.Silver));
    }

    private void Buy(ResourcesType type)
    { 
        var item=itemManager.GetId(id);
        
        
        if(item != null)
        {
            bool pursehed=resourcesManager.Purches(item,type);

        }

    }


}
