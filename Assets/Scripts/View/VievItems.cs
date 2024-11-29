using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VievItems : MonoBehaviour
{
    [SerializeField] private ItemManager manager;
    [SerializeField] private TMP_Text sword;
    [SerializeField] private TMP_Text sword1;
    [SerializeField] private TMP_Text sword2;
    [SerializeField] private Image swordImage;
    [SerializeField] private Image sword1Image;
    [SerializeField] private Image sword2Image;
    [SerializeField] private TMP_Text swordRemaining;
    [SerializeField] private TMP_Text sword1Remaining;
    [SerializeField] private TMP_Text sword2Remaining;
    void Start()
    {
        ItemView();   
    }

    private void Update()
    {
        IsAvaibleView();
        GetTimeRemaning();
    }


    private void ItemView()
    {
        sword.text = $"{manager.DisplayItems(1)}";
        sword1.text = $"{manager.DisplayItems(2)}";
        sword2.text = $"{manager.DisplayItems(3)}";
    }

    private void GetTimeRemaning()
    {
        TimeSpan time  = TimeSpan.FromSeconds(manager.GetTimeRemaning(0));
        TimeSpan time1 = TimeSpan.FromSeconds(manager.GetTimeRemaning(1));
        TimeSpan time2 = TimeSpan.FromSeconds(manager.GetTimeRemaning(2));

        swordRemaining.text=$"{time.Minutes:D2}:{time.Seconds:D2}";
        sword1Remaining.text = $"{time1.Minutes:D2}:{time1.Seconds:D2}";
        sword2Remaining.text = $"{time2.Minutes:D2}:{time2.Seconds:D2}";


    }
    private void IsAvaibleView()
    {
        if (manager.IsVisible(1))
        {
            swordImage.color = Color.red; 
        }
        else
            swordImage.color = Color.white;

        if (manager.IsVisible(2))
        {
            sword1Image.color = Color.red; 
        }
        
        else
            sword1Image.color = Color.white;
        
        
        if (manager.IsVisible(3))
        { 
            sword2Image.color = Color.red; 
        }
        else
            sword2Image.color = Color.white;


    }

  
}
