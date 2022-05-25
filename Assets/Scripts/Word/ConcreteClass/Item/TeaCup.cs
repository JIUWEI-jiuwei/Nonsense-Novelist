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
        wordName = "茶杯";
        bookName = BookNameEnum.HongLouMeng;
        getWay = GetWayEnum.NormalWord;
        description = "一个相当精致的茶杯";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.all;
        san = 3;
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

            return character.wordName+"拿出了一个上大下小的碧绿方形茶杯。";
        
    }
}
