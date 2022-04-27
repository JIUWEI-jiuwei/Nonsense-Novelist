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
        description = "一个和尚传来的“海上仙方”，是制作相当复杂的药丸";
        camp = CampEnum.all;
        banUse.Add(gameObject.AddComponent<Biology>());
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();
        level = 1;
    }
}
