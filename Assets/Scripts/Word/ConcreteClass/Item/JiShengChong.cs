using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///寄生虫
/// </summary>
class JiShengChong : AbstractItems
{
    public void Awake()
    {
        itemID = 11;
        wordName = "寄生虫";
        bookName = BookNameEnum.Epidemiology;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        //*************************************在父类写身份限制*************************************
        VoiceEnum = MaterialVoiceEnum.Meat;
        def=-3;
        attackInterval = -0.3f;
    }
}
