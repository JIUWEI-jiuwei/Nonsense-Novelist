using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 日轮挂坠
/// </summary>
class RiLunGuaZhui : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 5;
        wordName = "日轮挂坠";
        bookName = BookNameEnum.EgyptMyth;
        description = "加5精神";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psy += 5;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        
    }

    public override void End()
    {
        base.End();
        aim.psy -= 5;
    }
}
