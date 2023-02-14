using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 荷鲁斯之眼
/// </summary>
class HorusEyes : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 6;
        wordName = "荷鲁斯之眼";
        bookName = BookNameEnum.EgyptMyth;
        description = "一枚熠熠生辉的宝石，提升7点精神，增强暴击倍数。";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 5;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
