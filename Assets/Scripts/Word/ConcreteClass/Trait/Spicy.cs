using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 辣性格
/// </summary>
class Spicy : AbstractTrait
{
    public void Awake()
    {
        traitID = 4;
        traitName = "辣";
        description = "咄咄逼人绝不会吃一点亏，容易伤到他人";
        growSP = 5;
        growPSY = 1.5f;
        growSAN = 0.6f;
        restrainRole.Add(1, 0.2f);
        restrainRole.Add(2, 0.2f);
        restrainRole.Add(5, 0.2f);
    }
}
