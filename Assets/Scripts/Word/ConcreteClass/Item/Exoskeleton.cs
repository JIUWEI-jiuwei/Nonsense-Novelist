using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///�����
/// </summary>
class Exoskeleton : AbstractItems
{
    public void Awake()
    {
        itemID = 12;
        wordName = "�����";
        bookName = BookNameEnum.PHXTwist;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.clothes;
        VoiceEnum = MaterialVoiceEnum.Meat;
        def=3;
        dodgeChance = 0.15f;
    }
}