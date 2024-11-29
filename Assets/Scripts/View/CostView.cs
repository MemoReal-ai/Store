using TMPro;
using UnityEngine;

public class CostView : MonoBehaviour
{
    [SerializeField] private ItemManager manager;
    [SerializeField] private TMP_Text swordCost;
    [SerializeField] private TMP_Text swordAltCost;
    [SerializeField] private TMP_Text sword1Cost;
    [SerializeField] private TMP_Text sword1AltCost;
    [SerializeField] private TMP_Text sword2Cost;
    [SerializeField] private TMP_Text sword2AltCost;


    void Start()
    {
        ViewCost();
    }

    private void ViewCost()
    {
        var (swordCostValue0, swordCostAltValue0) = manager.DisplayCost(1);
        var (swordCostValue1, swordCostAltValue1) = manager.DisplayCost(2);
        var (swordCostValue2, swordCostAltValue2) = manager.DisplayCost(3);

        swordCost.text = $"Купить золотом: {swordCostValue0}";
        swordAltCost.text = $"Купить серебром: {swordCostAltValue0}";

        sword1Cost.text = $"Купить золотом: {swordCostValue1}";
        sword1AltCost.text = $"Купить серебром: {swordCostAltValue1}";

        sword2Cost.text = $"Купить золотом: {swordCostValue2}";
        sword2AltCost.text = $"Купить серебром: {swordCostAltValue2}";
    }

}
