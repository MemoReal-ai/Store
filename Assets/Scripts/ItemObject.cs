using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Create Items")]
public class ItemObject :ScriptableObject
{
    public int id;
    public string name;
    public string type;
    public float cost;
    public float altCost;
    public float timeAfterPurches;
    public bool isAvailable;
    public float timeRemaining;


   
    public void TimeToEqiep()
    {

        if (isAvailable)
        {
            timeRemaining-= Time.deltaTime;
            if (timeRemaining <=0)
                isAvailable = false;
        }
        else 
            timeRemaining=timeAfterPurches;

    }

    public void ToogleActive()
    { 
        isAvailable = true;
        timeRemaining = timeAfterPurches;
    }
}

