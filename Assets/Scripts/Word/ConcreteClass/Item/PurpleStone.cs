using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ×ÏË®¾§
/// </summary>
class PurpleStone: AbstractItems
{
    public void Awake()
    {
        itemID = 7;
        wordName = "×ÏË®¾§";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        psy = 3;
        multipleCriticalStrike = 0.5f;
    }
}
