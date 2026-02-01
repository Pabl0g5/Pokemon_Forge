using UnityEngine;

[CreateAssetMenu(menuName = "Pokémon Forge/Misc/Flavour")]
public class FlavourData : ScriptableObject
{
    [Header("Identity")]
    public string id;
    public string displayName;
}
