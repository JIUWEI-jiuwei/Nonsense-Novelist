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
        appearence = 2;
        nickname = "制作相当复杂的药丸";
        VoiceEnum = MaterialVoiceEnum.materialNull;


    }
}
