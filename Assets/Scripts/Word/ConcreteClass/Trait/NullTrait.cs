using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 无性格
/// </summary>
class NullTrait : AbstractTrait
{
    public void Awake()
    {
        traitID = 0;
        traitName = "无性格";
    }
}
