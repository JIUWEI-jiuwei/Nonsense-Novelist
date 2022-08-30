using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///外骨骼
/// </summary>
class Exoskeleton : AbstractItems
{
    public void Awake()
    {
        itemID = 12;
        wordName = "外骨骼";
        bookName = BookNameEnum.PHXTwist;
        getWay = GetWayEnum.NormalWord;
        description = "厚厚的几丁质外壳能保护其主人，提升3点防御，15%闪避几率。";
        holdEnum = HoldEnum.clothes;
        VoiceEnum = MaterialVoiceEnum.Meat;
        def=3;
        dodgeChance = 0.15f;
    }
}
