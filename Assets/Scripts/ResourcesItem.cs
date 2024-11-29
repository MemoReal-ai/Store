using UnityEngine;


public enum ResourcesType 
{
    Silver,
    Gold
}



[System.Serializable]
public class ResourcesItem
{
   [SerializeField] private ResourcesType _name;
   
   public float amount;
    public ResourcesType Name => _name;
        public ResourcesItem(ResourcesType name,float amount)
    {
        _name = name;
        this.amount = amount;
    }
}
