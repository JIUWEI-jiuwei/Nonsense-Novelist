using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 野兽
/// </summary>
class Beast : AbstractRole
{
    public void Awake()
    {
        roleID = 7;
        roleName = "野兽";
        description = "没有理智的动物";
    }
}
