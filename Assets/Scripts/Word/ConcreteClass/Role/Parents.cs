using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 家长
/// </summary>
class Parents : AbstractRole
{
    public void Awake()
    {
        roleID = 4;
        roleName = "家长";
        description = "喋喋不休的家长";
    }
}
