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
        description = "һö�������Եı�ʯ������7�㾫����ǿ����������";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        psy = 7;
        multipleCriticalStrike = 1;
    }
}
