using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///������
/// </summary>
class JiShengChong : AbstractItems
{
    public void Awake()
    {
        itemID = 11;
        wordName = "������";
        bookName = BookNameEnum.Epidemiology;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Meat;
        def=-3;
        attackInterval = -0.3f;
    }
}
