using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 宿敌
/// </summary>
class OldEnemy : AbstractRole
{
    public void Awake()
    {
        roleID = 5;
        roleName = "宿敌";
        description = "针锋相对却又总是相遇的对手";
    }
}
