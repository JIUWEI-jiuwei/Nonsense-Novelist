using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 痴性格
/// </summary>
class Obsessed : AbstractTrait
{
    public void Awake()
    {
        traitID = 6;
        traitName = "痴";
        description = "对贪恋的事物如痴如醉";
    }
}
