using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 纨绔
/// </summary>
class Noble : AbstractRole
{
    public void Awake()
    {
        roleID = 1;
        roleName = "纨绔";
        description = "游手好闲的子弟";
    }
}
