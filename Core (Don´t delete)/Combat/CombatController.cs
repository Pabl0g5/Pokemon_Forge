using System.Collections.Generic;
using UnityEngine;

public class TypeChart
{
    private Dictionary<(string attacker, string defender), float> lookup;

    public float GetMultiplier(TypeData attacker, TypeData defender)
    {
        if (lookup.TryGetValue((attacker.id, defender.id), out float value))
            return value;

        return 1f;
    }
}

public static class TypeEffectivenessCalculator
{
    public static float Calculate(TypeChart chart, TypeData attackType, ITypeHolder defender)
    {
        float multiplier = 1f;

        var defenderTypes = defender.GetActiveTypes();

        foreach (var defenseType in defenderTypes)
        {
            float typeMultiplier = chart.GetMultiplier(attackType, defenseType);

            multiplier *= typeMultiplier;

            if (multiplier == 0f)
                break;
        }

        return multiplier;
    }
}