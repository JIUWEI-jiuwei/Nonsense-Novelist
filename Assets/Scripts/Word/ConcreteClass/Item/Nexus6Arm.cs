using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Nexus-6型手臂
/// </summary>
class Nexus6Arm : AbstractItems
{
    public void Awake()
    {
        itemID = 10;
        wordName = "Nexus-6型手臂";
        bookName = BookNameEnum.ElectronicGoal;
        getWay = GetWayEnum.NormalWord;
        description = "一种已经停产的强大机械臂，提升10点攻击，10%暴击几率。";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;
        atk =10;
        criticalChance = 0.1f;
    }
}
