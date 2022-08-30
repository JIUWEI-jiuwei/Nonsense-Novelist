using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 虎眼石
/// </summary>
class TigerStone: AbstractItems
{
    public void Awake()
    {
        itemID = 8;
        wordName = "虎眼石";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        atk = 3;
        multipleCriticalStrike = 0.5f;
    }
}
