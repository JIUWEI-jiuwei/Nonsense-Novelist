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
        description = "难以定义的性格";
        growSP = 5;
        growPSY = 1.2f;
        growSAN = 0.7f;
    }
}
