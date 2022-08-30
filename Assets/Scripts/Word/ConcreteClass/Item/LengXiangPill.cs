using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 服药
/// </summary>
class LengXiangPill : AbstractItems
{
    public void Awake()
    {
        itemID = 2;
        wordName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        getWay = GetWayEnum.NormalWord;
        description = "一枚制作相当复杂的药丸，提升3点防御。";
        banUse.Add(gameObject.AddComponent<Biology>());
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = gameObject.AddComponent<FuYao>();


    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "白牡丹花蕊、白荷花花蕊、白芙蓉花蕊、白梅花花蕊......等十年未必都这样巧能做出这冷香丸呢！”" + character.wordName + "说道。";

    }
}
