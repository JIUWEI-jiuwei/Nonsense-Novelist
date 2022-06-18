using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 日轮挂坠
/// </summary>
class RiLunGuaZhui : AbstractItems
{
    public void Awake()
    {
        itemID = 5;
        wordName = "日轮挂坠";
        bookName = BookNameEnum.EgyptMyth;
        getWay = GetWayEnum.NormalWord;
        description = "一枚熠熠生辉的宝石，提升7点精神，增强暴击倍数。";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        psy = 7;
        multipleCriticalStrike = 1;
    }
}
