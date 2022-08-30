using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 紫水晶
/// </summary>
class PurpleStone: AbstractItems
{
    public void Awake()
    {
        itemID = 7;
        wordName = "紫水晶";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "一颗深紫色高洁的水晶，提升3点精神，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        psy = 3;
        multipleCriticalStrike = 0.5f;
    }
}
