using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ֹ�׹
/// </summary>
class RiLunGuaZhui : AbstractItems
{
    public void Awake()
    {
        itemID = 5;
        wordName = "���ֹ�׹";
        bookName = BookNameEnum.EgyptMyth;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        psy = 7;
        multipleCriticalStrike = 1;
    }
}
