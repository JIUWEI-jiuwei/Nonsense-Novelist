using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 慈悲性格
/// </summary>
class Mercy :AbstractTrait
{
    public void Awake()
    {
        traitID = 7;
        traitName = "慈悲";
        description = "珍惜生命且善待他人";
        growSP = 3;
        growPSY = 0.9f;
        growSAN = 1.2f;
        restrainRole.Add(4, 0.3f);
    }
}
