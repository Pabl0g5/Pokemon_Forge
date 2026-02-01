 using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffectData : ScriptableObject
{
    [Header("Basic Info")]
    public string id;
    public string displayName;
    [TextArea] public string description;

    [Header("Rules")]
    public bool isPermanet;
    public int maxDuration;
    public StatusStackRule stackRule;

    [Header("DamageOverTime")]
    public float damagePercentPerTurn;

    [Header("Stat Modifier")]
    public StatsData stat;
    public StatModifierType modifier;
    public float value;
}

