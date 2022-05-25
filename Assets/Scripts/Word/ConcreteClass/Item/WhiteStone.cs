using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// °×Ë®¾§
/// </summary>
class WhiteStone: AbstractItems
{
    public void Awake()
    {
        itemID = 6;
        wordName = "°×Ë®¾§";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        atk = 1;
        def = 1;
        psy = 1;
        san = 1;
    }
}
