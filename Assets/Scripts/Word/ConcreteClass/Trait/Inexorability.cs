using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷酷性格
/// </summary>
class Inexorability : AbstractTrait
{
    public void Awake()
    {
        traitID = 2;
        traitName = "冷酷";
        description = "内心冰冷但对热情的人感到头疼";
        growSP = 5;
        growPSY = 1.3f;
        growSAN = 0.7f;
        restrainRole.Add(1, 0.2f);
        restrainRole.Add(6, 0.5f);
}
}
