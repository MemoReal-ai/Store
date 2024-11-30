using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private ItemManager itemManager;
   [SerializeField] private ResourcesManager resources;
   [SerializeField] private DataPeresistense dataPeresistense;

    private void Start()
    {
        dataPeresistense.LoadGame(resources, itemManager);
    }
    private void OnApplicationQuit()
    {
        dataPeresistense.SaveGame(resources, itemManager);
    }
}

