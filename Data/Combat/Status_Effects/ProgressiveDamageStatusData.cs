using UnityEngine;

[CreateAssetMenu(menuName = "Pokémon Forge/Status Effects/Progresive Damage")]
public class ProgressiveDamageStatusData : StatusEffectData
{
    [Header("Progresive Damage")]
    public float baseDamagePercentage;
    public bool resetsOnSwitch = true;
}
