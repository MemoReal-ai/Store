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

        swordCost.text = $"������ �������: {swordCostValue0}";
        swordAltCost.text = $"������ ��������: {swordCostAltValue0}";

        sword1Cost.text = $"������ �������: {swordCostValue1}";
        sword1AltCost.text = $"������ ��������: {swordCostAltValue1}";

        sword2Cost.text = $"������ �������: {swordCostValue2}";
        sword2AltCost.text = $"������ ��������: {swordCostAltValue2}";
    }

}
