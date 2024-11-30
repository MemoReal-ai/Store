    using UnityEngine;
using Unity.UI;
using TMPro;

public class ResourcesDisplay : MonoBehaviour
{
    [SerializeField] private ResourcesManager manager;
    [SerializeField] private TMP_Text gold;
    [SerializeField] private TMP_Text silver;

    private void Start()
    {
        DisplayResources();
    }
    private  void Update()
    {
        DisplayResources();

    }

    private void DisplayResources()
    {

        gold.text = $"Gold-{manager.GetInfoResources(ResourcesType.Gold)}";
        silver.text = $"Silver-{manager.GetInfoResources(ResourcesType.Silver)}";
    }
}
