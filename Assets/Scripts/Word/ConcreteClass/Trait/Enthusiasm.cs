using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 热情性格
/// </summary>
class Enthusiasm : AbstractTrait
{
    public void Awake()
    {
        traitID = 3;
        traitName = "热情";
        description = "热情开朗但不懂得如何处理细腻的感情";
    }
}
