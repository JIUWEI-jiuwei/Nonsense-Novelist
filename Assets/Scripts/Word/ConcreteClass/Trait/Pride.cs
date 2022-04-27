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
        growSP = 3;
        growPSY = 0.7f;
        growSAN = 0.7f;
        restrainRole.Add(1, 0.3f);
        restrainRole.Add(3, 0.3f);
    }
}
