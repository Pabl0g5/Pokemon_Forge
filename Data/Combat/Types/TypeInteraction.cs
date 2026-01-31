using System;
using UnityEngine;

public enum Effectiveness
{
    None,
    Half,
    Normal,
    Double
}

[Serializable]
public class TypeInterction
{
    public TypeData attacker;
    public TypeData defender;
    public Effectiveness effectiveness;
}