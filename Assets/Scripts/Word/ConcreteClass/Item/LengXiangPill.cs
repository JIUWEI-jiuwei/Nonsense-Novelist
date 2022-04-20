using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷香丸
/// </summary>
class LengXiangPill : AbstractItems
{
  public LengXiangPill()
    {
        itemID = 2;
        itemName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        description = "一个和尚传来的“海上仙方”，是制作相当复杂的药丸";
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = new LengXiangPillSkill();
        level = 1;
    }
}
