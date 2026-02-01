using UnityEngine;

[CreateAssetMenu(menuName = "Pokémon Forge/Stats/Nature Data")]
public class NatureData : ScriptableObject
{
    [Header("Identity")]
    public string id;
    public string displayName;
    [TextArea] public string description;

    [Header("Stat Modifiers")]
    public StatsData increasedStat;
    public StatsData decreasedStat;

    [Header("Flavours")]
    public FlavourData likedFlavour;
    public FlavourData dislikedFlavour;
}
