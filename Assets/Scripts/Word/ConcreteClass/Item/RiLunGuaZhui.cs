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
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 5;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        
    }

    public override void End()
    {
        base.End();
        aim.psy -= 5;
    }
}
