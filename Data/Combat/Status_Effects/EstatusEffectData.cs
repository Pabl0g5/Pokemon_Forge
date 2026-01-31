using System;
using Unity.VisualScripting;
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
}

