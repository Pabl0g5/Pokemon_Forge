using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class BattleCreature : ITypeHolder
{
    private List<TypeData> baseTypes;
    private List<TypeData> extraTypes;

    public IReadOnlyList<TypeData> GetActiveTypes()
    {
        List<TypeData> result = new List<TypeData>();
        result.AddRange(baseTypes);
        result.AddRange(extraTypes);
        return result;
    }

    public void AddExtraType(TypeData type)
    {
        if (!extraTypes.Contains(type))
            extraTypes.Add(type);
    }

    public void RemoveExtraType(TypeData type)
    {
        extraTypes.Remove(type);
    }
}
