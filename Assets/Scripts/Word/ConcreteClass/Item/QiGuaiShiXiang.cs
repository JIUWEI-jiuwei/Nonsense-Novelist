using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词：奇怪石像
/// </summary>
class QiGuaiShiXiang : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 22;
        wordName = "奇怪石像";
        bookName = BookNameEnum.allBooks;
        description = "精神+1";

        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psy += 1;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.psy -= 1;
    }
}
