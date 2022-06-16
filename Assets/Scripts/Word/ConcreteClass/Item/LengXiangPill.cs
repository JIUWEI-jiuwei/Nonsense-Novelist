using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷香丸
/// </summary>
class LengXiangPill : AbstractItems
{
    public void Awake()
    {
        itemID = 2;
        wordName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        getWay = GetWayEnum.NormalWord;
        description = "一个和尚传来的“海上仙方”，是制作相当复杂的药丸";
        camp = CampEnum.all;
        banUse.Add(gameObject.AddComponent<Biology>());
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        camp = CampEnum.all;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();


    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "“花蕊，露水，蜂蜜……冷香丸的配方怎么这么复杂？”" + character.wordName + "说道。";

    }
}
