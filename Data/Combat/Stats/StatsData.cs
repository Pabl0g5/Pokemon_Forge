using UnityEngine;

public enum StatCategory
{
    Primary, 
    Secondary, 
    Custom
}

[CreateAssetMenu(menuName = "Pokémon Forge/Stats/Stats Data")]
public class StatsData : ScriptableObject
{
    [Header("Identity")]
    public string id;
    public string displayName;
    public StatCategory category;

    [Header("Rules")]
    public bool canBeModifiedInBattle = true;
    public bool isHidden = false;
}
