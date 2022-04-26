using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 傲性格
/// </summary>
class Pride :AbstractTrait
{
    public void Awake()
    {
        traitID = 5;
        traitName = "傲";
        description = "刚愎自用瞧不起他人";
    }
}
