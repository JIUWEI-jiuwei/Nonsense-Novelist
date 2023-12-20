using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：钝斧头
/// </summary>
class FuTouAxe : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 20;
        wordName = "钝斧头";

        bookName = BookNameEnum.allBooks;
        description = "攻击+1";
 
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 1;

    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 1;
    }
}
