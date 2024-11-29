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
    void Start()
    {
        ItemView();   
    }

    private void Update()
    {
        IsAvaibleView();
    }


    private void ItemView()
    {
        sword.text = $"{manager.DisplayItems(1)}";
        sword1.text = $"{manager.DisplayItems(2)}";
        sword2.text = $"{manager.DisplayItems(3)}";
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
