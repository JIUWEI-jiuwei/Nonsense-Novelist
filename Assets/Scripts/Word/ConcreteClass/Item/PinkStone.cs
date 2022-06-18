using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 粉水晶
/// </summary>
class PinkStone: AbstractItems
{
    public void Awake()
    {
        itemID = 9;
        wordName = "粉水晶";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "一枚粉色柔和的水晶，提升3点意志，15%闪避几率。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        psy = 3;
        dodgeChance += 0.15f;
    }
}
