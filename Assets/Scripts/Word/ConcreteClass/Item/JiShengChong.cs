using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///¼ÄÉú³æ
/// </summary>
class JiShengChong : AbstractItems
{
    public void Awake()
    {
        itemID = 11;
        wordName = "¼ÄÉú³æ";
        bookName = BookNameEnum.Epidemiology;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Meat;
        def=-3;
        attackInterval = -0.3f;
    }
}
