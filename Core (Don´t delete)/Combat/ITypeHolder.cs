using System.Collections.Generic;
using UnityEngine;

public interface ITypeHolder
{
    IReadOnlyList<TypeData> GetActiveTypes();
}
