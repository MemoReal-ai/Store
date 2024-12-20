using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
        ActiveButton();
    }

    private void Update()
    {
        ActiveButton();
    }
    private void Buy(ResourcesType type)
    { 
        var item=itemManager.GetItem(id);
        
        
        if(item != null)
        {
            bool pursehed=resourcesManager.Purches(item,type);


        }

    }

    private void ActiveButton( )
    {
        var  item = itemManager.GetItem(id);
        buttonGold.interactable=!item.isAvailable;
        buttonSilver.interactable =!item.isAvailable;
    }


}
