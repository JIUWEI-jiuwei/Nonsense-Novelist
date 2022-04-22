using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 茶杯
/// </summary>
class TeaCup : AbstractItems
{
    public void Awake()
    {
        itemID = 1;
        itemName = "茶杯";
        bookName = BookNameEnum.HongLouMeng;
        description = "一个相当精致的茶杯";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        level = 1;

    }
}
