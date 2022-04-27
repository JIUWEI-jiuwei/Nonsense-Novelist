using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敏感性格
/// </summary>
class Sentimental :AbstractTrait
{
    public void Awake()
    {
        traitID = 1;
        traitName = "敏感";
        description = "容易受伤却又极富有洞察力的性格";
        growSP = 8;
        growPSY = 1.7f;
        growSAN = 0.3f;
        restrainRole.Add(3, 0.1f);
        restrainRole.Add(6, 0.5f);
    }
}
